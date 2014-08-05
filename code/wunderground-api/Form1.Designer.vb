<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgLabel = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"United States", "Afghanistan", "Albania", "Alberta", "Algeria", "Angola", "Anguilla", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Beijing", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bolivia", "Bosnia", "Botswana", "Bouvet Island", "Brazil", "British Columbia", "British Indian Ocean", "British Virgin Islands", "Brunei", "Bulgaria", "Burkina Faso", "Burma/Myanmar", "Burundi", "Cambodia", "Cameroon", "Canada", "Canary Islands", "Canton Island", "Cape Verde", "Capital Territory", "Caroline Islands", "Cayman Island", "Central African Republic", "Chad", "Cheng-Du", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Democratic Yemen", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guam", "Guang-Zhou", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Han-Kou", "Hawaii", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Lan-Zhou", "Lao Peoples Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Luxembourg", "Macao", "Macedonia", "Madagascar", "Madeira Islands", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Manitoba", "Mariana Islands", "Marshall Islands", "Martinique", "Maryland", "Mauritania", "Mauritius", "Mexico", "Mongolia", "Montana", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "New Brunswick", "New Caledonia", "New South Wales", "New Zealand", "Newfoundland", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Pacific Islands", "Norway", "Nova Scotia", "Oman", "Pakistan", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Prince Edward Island", "Puerto Rico", "Qatar", "Republic of Moldova", "Reunion Island", "Romania", "Russia", "Rwanda", "Saudi Arabia", "Senegal", "Seychelles", "Shang-Hai", "Shen-Yang", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "Southern Line Islands", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Tasmania", "Thailand", "Togo", "Tokelau Island", "Tonga", "Trinidad And Tobago", "Tunisia", "Turkey", "Turks Islands", "Tuvalu", "United States", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Urum-Qui", "Uzbekistan", "Vanuata", "Venezuela", "Victoria", "Viet Nam", "Virgin Islands", "Virginia", "Wake Island", "Wallis And Futuna Island", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Yukon Territory", "Zambia", "Zimbabwe"})
        Me.ComboBox1.Location = New System.Drawing.Point(75, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Country"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebControl1
        '
        Me.WebControl1.Location = New System.Drawing.Point(0, 0)
        Me.WebControl1.Size = New System.Drawing.Size(0, 0)
        Me.WebControl1.Source = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 9
        Me.WebControl1.ViewType = Awesomium.Core.WebViewType.Offscreen
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'Timer2
        '
        Me.Timer2.Interval = 2500
        '
        'Timer3
        '
        Me.Timer3.Interval = 2500
        '
        'Timer4
        '
        Me.Timer4.Interval = 2500
        '
        'Timer5
        '
        Me.Timer5.Interval = 2500
        '
        'Timer6
        '
        Me.Timer6.Interval = 2500
        '
        'Timer7
        '
        Me.Timer7.Interval = 2500
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.ProgLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 122)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'ProgLabel
        '
        Me.ProgLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgLabel.AutoSize = True
        Me.ProgLabel.Location = New System.Drawing.Point(21, 11)
        Me.ProgLabel.Name = "ProgLabel"
        Me.ProgLabel.Size = New System.Drawing.Size(150, 13)
        Me.ProgLabel.TabIndex = 11
        Me.ProgLabel.Text = "Connecting to Wunderground "
        Me.ProgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 91)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 7
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(166, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Timer8
        '
        Me.Timer8.Interval = 120000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 122)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Enter your info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgLabel As System.Windows.Forms.Label
    Friend WithEvents Timer8 As System.Windows.Forms.Timer

End Class
