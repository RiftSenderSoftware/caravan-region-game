using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    //Basic card values
    public int cardID;
    public string cardName;
    public CardSprite sprite;
    public string dialogue;

    public string leftQuote;
    public string rightQuote;

    // Impact values
    // Left
    /*
    public int sPoliceLeft;
    public int sDefendLeft;
    public int sOfficeLeft;
    public int sMoneyLeft;
    */
    // Right
    /*
    public int sPoliceRight;
    public int sDefendRight;
    public int sOfficeRight;
    public int sMoneyRight;
    */

    public void Left()
    {
        /*
        UnityEngine.Debug.Log(cardName + "swipe left");
        //Appending the values
        CardManager.statisticPolice += sPoliceLeft;
        CardManager.statisticDefend += sDefendLeft;
        CardManager.statisticOffice += sOfficeLeft;
        CardManager.statisticMoney += sMoneyLeft;
        */
    }
    public void Right()
    {
        /*
        UnityEngine.Debug.Log(cardName + "swipe right");
        CardManager.statisticPolice += sPoliceRight;
        CardManager.statisticDefend += sDefendRight;
        CardManager.statisticOffice += sOfficeRight;
        CardManager.statisticMoney += sMoneyRight;
        */
    }
}
