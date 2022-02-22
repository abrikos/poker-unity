using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
	
	public void OnMouseDown(){
	    Debug.Log("Hi");
    }

    public void onClick()
    {
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
