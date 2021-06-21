using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;
using System.Text;

public class beachVR : MonoBehaviour
{
    BluetoothHelper bluetoothHelper;
    BluetoothHelper bluetoothHelper2;
    string deviceName;

    string received_message;
    bool triggerEnter = false;
    float progress = 0f;

    public UnityEvent selectEvent;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        Debug.Log("sadf");
        deviceName = "HC-06"; //bluetooth should be turned ON;
        try
        {

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
        if (triggerEnter)
        {
            progress = progress + Time.deltaTime;
            GetComponent<Slider>().value = progress;

            if (progress >= 3f)
            {
                selectEvent.Invoke();
                SceneManager.LoadScene("ocean");

            }
        }
    }
    void OnGazeEnter()
    {
        triggerEnter = true;
    }
    void OnGazeExit()
    {
        triggerEnter = false;
        progress = 0f;
        GetComponent<Slider>().value = 0f;
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