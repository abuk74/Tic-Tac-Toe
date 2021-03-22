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
        StartCoroutine(ChangeRound());
    }
    IEnumerator ChangeRound()
    {
        yield return new WaitForEndOfFrame();
        roundText.text = "Round" + round;
    }
}
