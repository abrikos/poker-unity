using UnityEngine;
using WebSocketSharp;
using System.Collections;
 using UnityEngine.Networking;

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
        LoadFromServer("https://ya.ru");
    }

IEnumerator LoadFromServer(string url)
{
    var request = new UnityWebRequest(url);

    yield return request.SendWebRequest();

    Debug.Log(request.downloadHandler.text);

    request.Dispose();
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