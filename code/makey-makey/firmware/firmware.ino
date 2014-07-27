//You may want to edit the values inside delay()
//to calibrate your RC car with the blinds

int blindsUp = 15;
int blindsDown = 16;
int ledPin = 14;
int buttonIn = 13;
int doorPin = 12;
boolean oldDoorValue = false;
int lastAvailable = 0;
int incomingByte = 0;

void setup() {                
  pinMode(blindsUp, OUTPUT);     
  pinMode(blindsDown, OUTPUT);  
  pinMode(ledPin, OUTPUT);     
  pinMode(buttonIn, INPUT);  
  pinMode(doorPin, INPUT);  
}

void loop() {
  if(Serial.available() != lastAvailable) {
    lastAvailable = Serial.available();
    incomingByte = Serial.read();
    if(incomingByte=='U') {
      digitalWrite(blindsUp, HIGH);   // turn the LED on (HIGH is the voltage level)
      delay(800);  // wait for three-fourths of a second
      digitalWrite(blindsUp, LOW);    // turn the LED off by making the voltage LOW
    }
    if(incomingByte=='D') {
      digitalWrite(blindsDown, HIGH);   // turn the LED on (HIGH is the voltage level)
      delay(800);  // wait for three-fourths of a second
      digitalWrite(blindsDown, LOW);    // turn the LED off by making the voltage LOW
    }
    if(incomingByte=='Y') {
      digitalWrite(ledPin, HIGH);
    }
    if(incomingByte=='N') {
      digitalWrite(ledPin, LOW);
    }
  }
  if(digitalRead(buttonIn) == true) {
    Serial.print("B");
  }
  if(digitalRead(doorPin) != oldDoorValue) {
    oldDoorValue = digitalRead(doorPin);
    if (digitalRead(doorPin) == true)
    {
    Serial.print("C");
    }
    if (digitalRead(doorPin) == false)
    {
    Serial.print("O");
    }
  }
//  while (Serial.available() == lastAvailable || digitalRead(buttonIn) == true || digitalRead(doorPin) != oldDoorValue)
//  {
//    lastAvailable = Serial.available();
//    incomingByte = Serial.read();
//    if(incomingByte=='U') {
//      digitalWrite(blindsUp, HIGH);   // turn the LED on (HIGH is the voltage level)
//      delay(800);  // wait for three-fourths of a second
//      digitalWrite(blindsUp, LOW);    // turn the LED off by making the voltage LOW
//    }
//    if(incomingByte=='D') {
//      digitalWrite(blindsDown, HIGH);   // turn the LED on (HIGH is the voltage level)
//      delay(800);  // wait for three-fourths of a second
//      digitalWrite(blindsDown, LOW);    // turn the LED off by making the voltage LOW
//    }
//  }
}




