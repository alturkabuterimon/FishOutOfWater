using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.Networking;


public class datain : MonoBehaviour
{
    private WebSocket ws = new WebSocket("wss://cf-nodered.herokuapp.com/ws/out/");
    public float CurrentState = 0f;
    private Renderer _renderer;
    public Color _color;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>(); // do this in awake, it has an impact on performances in Update
        //_color = _renderer.materials[0].GetColor("_TintColor");
        _color = _renderer.materials[0].color;
    }




    void Start()
    {
        Debug.Log("starting websocket");
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log(e.Data);
            CurrentState = float.Parse(e.Data);
        };
            


        ws.OnOpen += (sender, e) => {
            Debug.Log("Connected to NodeRED");


        };
        ws.Connect();
    }

    void Update()
    {
        _color.a = CurrentState;
        //_renderer.materials[0].SetColor("_TintColor", _color);

        _renderer.materials[0].color = _color;
    }
}

