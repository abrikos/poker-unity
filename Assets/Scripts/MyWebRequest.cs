using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyWebRequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Webrequest Starrrrrrrrt");
        StartCoroutine(GetRequest("https://poker-local.abrikos.pro/api", (UnityWebRequest req) =>
        {
            if (req.isNetworkError || req.isHttpError)
            {
                Debug.Log($"{req.error}: {req.downloadHandler.text}");
            } else
            {
                Debug.Log("zzzzzzzzzz" + req.downloadHandler.text);
            }
        }));
   
    }

    IEnumerator GetRequest(string url, Action<UnityWebRequest> callback)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            request.certificateHandler = new WebCertificate();
            // Send the request and wait for a response
            yield return request.SendWebRequest();
            callback(request);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
