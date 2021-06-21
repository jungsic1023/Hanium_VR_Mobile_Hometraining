//Connect TX pin of the HC-05 to RX pin of the Arduino
//Connect RX pin of the HC-05 to TX pin of the Arduino
//You can use SoftwareSerial Library, but i dont recommend it for fast and long data transmission
//Otherwise you have to check Serial.available() > excepted number of bytes sent before reading the message
//There's no problem with hardware serial that comes with the arduino. It's perfect
//
#include <SoftwareSerial.h>
#include <Wire.h>
#define BT_RX 7
#define BT_TX 8

SoftwareSerial mySerial(BT_RX, BT_TX); // RX, TX
const int hallPin = 10;     //홀 센서를A2핀에 연결
int sensorReading;  

void readBT();
void sendBT(const char * data, int l)
{
  byte len[4];
  len[0] = 85;//preamble
  len[1] = 85;//preamble
  len[2] = (l >> 8) & 0x000000FF;
  len[3] = (l & 0x000000FF);
  mySerial.write(len, 4); //len에 저장된 데이터 4만큼 전송
  mySerial.flush();
  mySerial.write(data, l);
  mySerial.flush();
}

void setup() {
  mySerial.begin(9600);
  Serial.begin(9600); 
}

char* data;
int data_length;
int i=0;
int timeout;
int highLow;
char* send_data;

void loop() {
  readBT();
  if (mySerial.available()) {
    Serial.write(mySerial.read());
  }
  if (Serial.available()) {
    mySerial.write(Serial.read());
  }
}


void readBT()
{
  if(mySerial.available() >= 2) //2byte의코드
  {
    timeout=0;
    data_length = 0;
    byte pre1 = mySerial.read();
    byte pre2 = mySerial.read();
    if(pre1 != 85 || pre2 != 85) return;
    while(mySerial.available() < 2) continue;
    byte x1 = mySerial.read();
    byte x2 = mySerial.read();

    data_length = x1 << 8 | x2;
    
    data = new char[data_length];
    i=0;
    while(i<data_length)
    {
        
      if(mySerial.available()==0){
        if(++timeout == 1000)
          goto FreeData;
        continue;
      }
      timeout=0;
      data[i++] = mySerial.read();
    }

    send_data = new char[data_length+1];
    send_data[0] = 'S';
    for(byte i=0; i<2;i++)
      send_data[i+1] = data[i];

    highLow = data[0] == 'E' ? HIGH : LOW;

    digitalWrite(data[1], highLow);

    sendBT(send_data, data_length+1);
    delete [] send_data;

    FreeData:
    delete[] data;
  }
}
