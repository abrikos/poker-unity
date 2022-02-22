using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlace : MonoBehaviour
{
    void Start()
    {
        //GameObject.Find("PlayerCard1").GetComponent<Image>.sprite = GameObject.Find("AllCards").GetComponent<PokerCards>().spriteArray[12];
        // GameObject.Find("PlayerCard1").SetActive(false);
        Debug.Log(GameObject.Find("PlayerCard1").GetComponent<SpriteRenderer>().sprite);
    }

    // Update is called once per frame
    void Update2()
    {
        if(Input.GetMouseButtonDown(0))
        {
            string rand = "7H";
            string rand2 = "QS";
            Debug.Log(GameObject.Find(rand));
            GameObject.Find("PlayerCard2").GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand).GetComponent<SpriteRenderer>().sprite;
            GameObject.Find("PlayerCard1").GetComponent<SpriteRenderer>().sprite= GameObject.Find(rand2).GetComponent<SpriteRenderer>().sprite;
            //GameObject.Find("PlayerCard1").GetComponent<SpriteRenderer>().sprite= GameObject.Find("AllCards").GetComponent<PokerCards>().spriteArray[12];
        }
        
    }
}
