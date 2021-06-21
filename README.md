한이음 모바일 기반 홈트레이닝 시스템
===================================

https://www.youtube.com/watch?v=BDSto9tyqjM&feature=youtu.be

-----

### 1. 아두이노 블루투스 연결
>#### 1-1 Arduino로 사용하는 센서
>#### 1-2 Arduino IDE에서 Uno보드에 센서들을 연결하여 Unity로 전송하는 코드
>#### 1-3 Unity에서 Arduino를 블루투스로 받는 방법
### 2. Unity 개발 
>#### 2-1 자유로운 맵 주행


<hr/>   

## 1. 아두이노 블루투스 연결

### 1-1 Arduino로 사용하는 센서
1. 자이로 가속도 센서 -> 자전거의 방향제어(좌 우)
2. 홀 센서 -> 자전거의 브레이크 제어
3. 적외선 센서 -> 자전거의 속도제어
4. 블루투스 모듈 -> 센서값 전송
<hr/>  

### 1-2 Arduino IDE에서 Uno보드에 센서들을 연결하여 Unity로 전송하는 코드

```cs
#include "SoftwareSerial.h"
#include "Wire.h"
SoftwareSerial mySerial(7, 8); // RX, TX //블루투스 센서
const int MPU_addr=0x68;  // I2C address of the MPU-6050
int16_t AcX,AcY,AcZ,Tmp,GyX,GyY,GyZ; //가속도 자이로센서
const int hallPin = 4; //홀센서
int infrared  = 3; //적외선센서
// LED는 디지털 6번핀으로 설정합니다.
int led = 6;
String sensorReading;   
String a = "2";
void setup() {
  Wire.begin();
  Wire.beginTransmission(MPU_addr);
  Wire.write(0x6B);  // PWR_MGMT_1 register
  Wire.write(0);     // set to zero (wakes up the MPU-6050)
  Wire.endTransmission(true);
 pinMode(infrared, INPUT);
  // LED 핀을 OUTPUT으로 설정합니다.
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  mySerial.begin(9600);
}
void loop(){
  sensorReading = digitalRead(hallPin); 
   int state = digitalRead(infrared);
  Wire.beginTransmission(MPU_addr);
  Wire.write(0x3B);  // starting with register 0x3B (ACCEL_XOUT_H)
  Wire.endTransmission(false);
  Wire.requestFrom(MPU_addr,14,true);  // request a total of 14 registers
  AcX=Wire.read()<<8|Wire.read();  // 0x3B (ACCEL_XOUT_H) & 0x3C (ACCEL_XOUT_L)    
  AcY=Wire.read()<<8|Wire.read();  // 0x3D (ACCEL_YOUT_H) & 0x3E (ACCEL_YOUT_L)
  AcZ=Wire.read()<<8|Wire.read();  // 0x3F (ACCEL_ZOUT_H) & 0x40 (ACCEL_ZOUT_L)
  //Tmp=Wire.read()<<8|Wire.read();  // 0x41 (TEMP_OUT_H) & 0x42 (TEMP_OUT_L)
  GyX=Wire.read()<<8|Wire.read();  // 0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
  GyY=Wire.read()<<8|Wire.read();  // 0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
  GyZ=Wire.read()<<8|Wire.read();  // 0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)
if(state == 0){
    // LED를 켜지도록 합니다.
    digitalWrite(led, HIGH);
    // 경보 메세지를 시리얼 모니터에 출력합니다.
  }
  /// 측정된 센서값이 0 이외(감지되지 않음) 이면 아래 블록을 실행합니다.
  else{
    // LED를 꺼지도록 합니다.
    digitalWrite(led, LOW);
    // 안전 메세지를 시리얼 모니터에 출력합니다.
     }
  if (mySerial.available())
    Serial.write(mySerial.read());
  if (Serial.available())
    Serial.println(sensorReading+" "+AcY+" "+AcX+" "+AcZ+" "+GyX+" "+GyY+" "+GyZ+" "+state);
  mySerial.println(sensorReading+" "+AcY+" "+AcX+" "+AcZ+" "+GyX+" "+GyY+" "+GyZ+" "+state);
  Serial.println(sensorReading+" "+AcY+" "+AcX+" "+AcZ+" "+GyX+" "+GyY+" "+GyZ+" "+state);
}
```
<hr/>   

# 2. Unity 개발 

### 2-1 자유로운 맵 주행

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;
using System.Text;
using UnityEngine.PlayerLoop;

using System.Linq;

public class dddfff : MonoBehaviour
{
    public Text countText;
    //public float moveSpeed = 5f;
    public int q=0;
    public float sp = 0;
    public float turnSpeed = 540f;
   public int x = 0;
    public int y = 0;

    BluetoothHelper bluetoothHelper;
    BluetoothHelper bluetoothHelper2;
    string deviceName;

    string received_message;

    void Start()
    {
        deviceName = "HC-06"; //bluetooth should be turned ON;
        try
        {
            Debug.Log("연결");
            bluetoothHelper = BluetoothHelper.GetInstance(deviceName);
            bluetoothHelper.OnConnected += OnConnected;
            bluetoothHelper.OnConnectionFailed += OnConnectionFailed;


            bluetoothHelper.Connect();
            bluetoothHelper.setTerminatorBasedStream("\n");

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);


        }
        
    }

    void Update()
    {

        if (bluetoothHelper != null)
        {
            if (bluetoothHelper.Available)
            {
                received_message = bluetoothHelper.Read();
                string text = received_message;
                string[] split_text = new string[8];
                split_text = text.Split(' ');

                //4줄아님 string[] Hall = new string[10];              
                //Hall[10] = split_text[0];
                //for (int i = 0; i < split_text.Length; i++)
                //Debug.Log(split_text[i]);

                int a = int.Parse(split_text[7]);
                Debug.Log("센서값 :" + a);
                if (a == 0) //적외선센서 a는 0// 
                {
                    x = x + 1;
                    y = 0;
                    if(x==1)
                    {
                        sp = 1;
                        x = 1;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 2)
                    {
                        sp = 1;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 3)
                    {
                        sp = 1;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 4)
                    {
                        sp = 1;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 5)
                    {
                        sp = 2;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 6)
                    {
                        sp = 2;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 7)
                    {
                        sp = 2;
                        y = 0;
                        countText.text = "Count: " + sp;

                    }
                    else if (x == 8)
                    {
                        sp = 2;
                        y = 0;

                    }
                    else if (x == 9)
                    {
                        sp = 3;
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                    else if (x == 10)
                    {
                        sp = 3;
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                    else if (x == 11)
                    {
                        sp = 3;
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                    else if (x == 12)
                    {
                        sp = 3;
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                    else if(x>12)
                    {
                        x = 12;
                        sp = 3;
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                }
                   

                
                if (a == 1) 
                {
                    y = y + 1;
                    if(x==0)
                    {
                        y = 0;
                        countText.text = "Count: " + sp;
                    }
                    if (x == 1)
                    {
                        if (y == 80)
                        {
                            sp = 0; 
                            x = 0;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }
                       

                    }
                    else if (x == 2)
                    {
                        if (y == 80)
                        {
                            sp = 0;
                            x = 0;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 3)
                    {
                        if (y == 80)
                        {
                            sp = 0;
                            x = 1;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 4)
                    {
                        if (y == 80)
                        {
                            sp = 0;
                            x = 1;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 5)
                    {
                        if (y == 80)
                        {
                            sp = 1;
                            x = 1;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 6)
                    {
                        if (y == 80)
                        {
                            sp = 1;
                            x = 2;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 7)
                    {
                        if (y == 80)
                        {
                            sp = 1;
                            x = 2;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 8)
                    {
                        if (y == 80)
                        {
                            sp = 1;
                            x = 3;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 9)
                    {
                        if (y == 80)
                        {
                            sp = 2;
                            x = 3;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 10)
                    {
                        if (y == 80)
                        {
                            sp = 2;
                            x = 4;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 11)
                    {
                        if (y == 80)
                        {
                            sp = 2;

                            x = 4; 
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }
                    else if (x == 12)
                    {
                        if (y == 80)
                        {
                            sp = 2;
                            x = 5;
                            y = 0;
                            countText.text = "Count: " + sp;
                        }

                    }                적외선 센서를 통한 속도제어

                }

               int br = int.Parse(split_text[0]);
                if(br==1) //브레이크//
                {
                    sp = 0;       홀센서를 통한 브레이크 제어
                }

                Debug.Log(q);
                Debug.Log("x = " + x);
                Debug.Log("y = " + y);

                float fMove = Time.deltaTime * sp;
                transform.Translate(Vector3.forward * fMove);
              
                //transform.Translate(Vector3.forward * fMove);

                int b = int.Parse(split_text[1]);

               


                float sum = 0;
                if (b>300 && b<=2000)
                {
                    transform.Rotate(0, 0, 0);
                }
                else if (b > 2000 && b <=3000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 20);
                }
                else if (b > 3000 && b <= 4000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 40);
                }
                else if (b > 4000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 60);
                } //오른쪽

                else if (b > 0 && b <= 300)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 20);
                }
                else if (b > -2000 && b <= 0 )
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 40);
                }
                else if (b <= -2000)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 60);  
                }//왼쪽
                
                자이로 가속도 센서를 통한 자전거의 방향제어
                
                Debug.Log("b = " + b);

                //transform.Rotate(0f, -10 * Time.deltaTime, 0f);

                //transform.Translate(Vector3.forward * fMove);
                // float h = Input.GetAxis("Horizontal");
                //float v = Input.GetAxis("Vertical");

                //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

                //Move
                //transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

                //Turn
                //  transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);

            }
         
        }
   }
    void restrcitX()
    {
        if(x < 0)
        {
            x = 0;
        }
    }
    void OnConnected()
    {
        try
        {
            bluetoothHelper.StartListening();
            bluetoothHelper2 = BluetoothHelper.GetNewInstance();
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

    }

    void OnConnectionFailed()
    {
        Debug.Log("Connection Failed");
    }

    void OnDestroy()
    {
        if (bluetoothHelper != null)
            bluetoothHelper.Disconnect();
    }

}
```
