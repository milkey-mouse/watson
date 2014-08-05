Module WhatsForLunch

    Public Function WhatsForLunch() As String
        Dim wc As New System.Net.WebClient
        wc.DownloadFile("http://www.lwsd.org/SiteCollectionDocuments/For-Parents/Menus/Lunch-Elementary.pdf", "G:\lunch.pdf")
        Dim f As New SautinSoft.PdfFocus()
        f.OpenPdf("G:\lunch.pdf")
        f.ToHtml("G:\lunch.htm", 1, 1)
        Dim html As New HtmlAgilityPack.HtmlDocument
        html.Load("G:\lunch.htm")
        Dim day As Integer = 0
        Try
            Dim dt As New DateTime(Date.Now.Year, Date.Now.Month, 1)
            Do While dt.DayOfWeek <> DayOfWeek.Monday
                dt = dt.AddDays(1)
            Loop
            day = dt.Day
        Catch
        End Try
        Dim targetDay As Integer = Date.Today.Day
        Dim finalText As String = ""
        For Each element As HtmlAgilityPack.HtmlNode In html.DocumentNode.ChildNodes.First.ChildNodes.Item(1).ChildNodes.First.ChildNodes
            If Not element.Name = "div" Then Continue For
            If element.HasChildNodes = False Then Continue For
            For Each child As HtmlAgilityPack.HtmlNode In element.ChildNodes
                If element.InnerText.Contains((day + 1).ToString()) = True Then day = day + 1
                If element.InnerText.Contains((day + 3).ToString()) = True Then day = day + 3
            Next
            If day = targetDay And finalText.Contains(element.InnerHtml) = False Then finalText = finalText + element.InnerText + vbCrLf
        Next
        finalText.Replace(targetDay.ToString, "")
        If finalText = "" Then finalText = (vbCrLf + "NO SCHOOL" + vbCrLf)
        finalText.Replace("NO SCHOOL", "No School")
        Return finalText.Replace(targetDay.ToString, "")
    End Function
End Module
