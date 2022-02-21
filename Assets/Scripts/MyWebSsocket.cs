using UnityEngine;
using WebSocketSharp;

public class MyWebSsocket : MonoBehaviour
{
    private WebSocket _ws;
    private void Start()
    {
        _ws = new WebSocket(url:"wss://poker-local.abrikos.pro/ws");
        _ws.Connect();
        _ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+e.Data);
        };
    }

    private void Update()
    {
        if(_ws == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ws.Send("Hello");
        }  
    }
}