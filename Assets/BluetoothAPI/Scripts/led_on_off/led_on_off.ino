#include <SoftwareSerial.h>

SoftwareSerial mySerial(7, 8); // RX, TX
String data = "";

void setup() {
  Serial.begin(9600);
  mySerial.begin(9600);
  pinMode(13, OUTPUT);
}



void loop()
{
    if (mySerial.availble()) 
    {
        data = mySerial.readStringUntil('\n');
        if(data == "O")
        {
            Serial.print("O");
            digitalWrite(13, HIGH);
        }else if(data == "F")
        {
            Serial.print("F");
            digitalWrite(13, LOW);
        }

        if (Serial.available()) {
          mySerial.write(Serial.read());
        }
    }

    delay(10);
}
