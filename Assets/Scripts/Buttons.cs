using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
	
	public void OnMouseDown(){
	    Debug.Log("Hi");
    }

	private static async Task SetTexture()
	{
		var tx = await MyWebRequest.Wr.GetRemoteTexture("https://www.gravatar.com/avatar/ac6d9001445d7245c83757179a650cf1?s=64&d=identicon&r=PG");
		GameObject.Find("RawImage").GetComponent<RawImage>().texture = tx;
	}

    public void onClick()
    {
	    SetTexture();
	    
	    const string rand = "7H";
	    const string rand2 = "QS";
	    Debug.Log(GameObject.Find(rand));
	    var player = GameObject.Find("Player1").transform;
	    var card1 = player.Find("PlayerCard1");
	    var card2 = player.Find("PlayerCard2");
	    card1.GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand).GetComponent<SpriteRenderer>().sprite;
	    card2.GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand2).GetComponent<SpriteRenderer>().sprite;
	    //GameObject.Find("PlayerCard2").GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand).GetComponent<SpriteRenderer>().sprite;
	    //GameObject.Find("PlayerCard1").GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand2).GetComponent<SpriteRenderer>().sprite;
    }

}
