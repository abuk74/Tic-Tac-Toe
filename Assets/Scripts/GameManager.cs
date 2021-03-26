using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text roundText;
    public string round;
    public Button[] buttons = new Button[9];

    void Start()
    {
        round = "X";
        StartCoroutine(ChangeRoundText());
    }
    public void ChangePlayerName()
    {
        if (round == "X")
            round = "O";
        else
            round = "X";
    }
    IEnumerator ChangeRoundText()
    {
        yield return new WaitForEndOfFrame();
        roundText.text = "Round" + round;
    }
    public void Victory(string playerName)
    {

    }
}
