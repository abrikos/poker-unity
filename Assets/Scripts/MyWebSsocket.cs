using UnityEngine;
using WebSocketSharp;
public class MyWebSsocket : MonoBehaviour
{
    WebSocket ws;
    private void Start()
    {
        ws = new WebSocket(url:"wss://poker-local.abrikos.pro/ws");
        Debug.Log("WS client" + JsonUtility.ToJson(ws, true));
        ws.Connect();
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+e.Data);
        };
    }
    
    private void Update()
    {
        if(ws == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ws.Send("Hello");
        }  
    }
}