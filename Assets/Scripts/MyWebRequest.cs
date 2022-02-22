using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class MyWebRequest : MonoBehaviour
{
    public static MyWebRequest Wr;

    void Start()
    {
        Test();
    }


    async Task Test()
    {
        var text = await GetRemoteJson("https://api.minter.one/v2/net_info");
        JObject json = JObject.Parse(text);
        Debug.Log(json["peers"]);
    }
    
    private void Awake()
    {
        Wr = this;
    }
    
    public async Task<Texture2D> GetRemoteTexture ( string url )
    {
        Debug.Log("-----------------------");
        using var www = UnityWebRequestTexture.GetTexture(url);
        // begin request:
        var asyncOp = www.SendWebRequest();
        // await until it's done: 
        while( asyncOp.isDone==false )
            await Task.Delay( 1000/30 );//30 hertz
        // read results:
        if( www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError )
            // if( www.result!=UnityWebRequest.Result.Success )// for Unity >= 2020.1
        {
            // log error:
            Debug.Log( $"{www.error}, URL:{www.url}" );
            // nothing to return on error:
            return null;
        }
        else
        {
            // return valid results:
            return DownloadHandlerTexture.GetContent(www);
        }
    }

    public async Task<string> GetRemoteJson ( string url )
    {
        Debug.Log("-----------------------");
        using var www = UnityWebRequestTexture.GetTexture(url);
        // begin request:
        var asyncOp = www.SendWebRequest();
        // await until it's done: 
        while( asyncOp.isDone==false )
            await Task.Delay( 1000/30 );//30 hertz
        // read results:
        if( www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError )
            // if( www.result!=UnityWebRequest.Result.Success )// for Unity >= 2020.1
        {
            // log error:
            Debug.Log( $"{www.error}, URL:{www.url}" );
            // nothing to return on error:
            return null;
        }
        else
        {
            // return valid results:
            return www.downloadHandler.text;
        }
    }


}
