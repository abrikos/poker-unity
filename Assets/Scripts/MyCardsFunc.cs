using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyCardsFunc
{
    private static string [] deck =  new string[52]; 
    private static string[] suits = new string[4]{"S", "C", "D", "H"};
    private static string[] values = new string[13]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

    public static string[] getDeck(){
        for (int i=0; i <52; i++)
            {
                int suit = Mathf.FloorToInt( i / 13);
                int value = i % 13;
                deck[i] = suits[suit] + values[value];
            }
            Debug.Log(deck[10]);
            return deck;
    }
}
