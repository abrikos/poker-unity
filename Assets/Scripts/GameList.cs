
using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class GameList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }
    public class GameRoot
    {
        public GameInfo Game { get; set; }
    }
    
    [Serializable]
    public class GameInfo
    {
        public string id;
    }

    public static GameRoot CreateFromJson(string jsonString)
    {
        return JsonUtility.FromJson<GameRoot>(jsonString);
    }
    
    [Serializable]
    public class Info
    {
        public string id;
    }

    async Task Test()
    {
        var text = await MyWebRequest.Wr.GetRemoteJson("https://poker.abrikos.pro/api/game/list");
        Debug.Log(text);
        var info = JsonUtility.FromJson<Info[]>("{1:2}");
        Debug.Log("zzzzzzzz");
        Debug.Log(info[0]);
        JObject json = JObject.Parse("[{1:2}]");
        Debug.Log(json[0]);
        /*for (int i = 0; i < json.Count; i++)
        {
            Debug.Log(json[i]);    
        }*/
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
