using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text roundText;
    public GameObject victoryPanel;
    public GameObject drawPanel;
    public string round;
    public Button[] buttons = new Button[9];

    void Start()
    {
        round = "X";
        roundText.text = "Round " + round;
    }
    public void ChangePlayerName()
    {
        if (round == "X")
            round = "O";
        else
            round = "X";
        roundText.text = "Round: " + round;
    }

    public void Victory(string playerName)
    {
        victoryPanel.SetActive(true);
        victoryPanel.transform.GetChild(1).GetComponent<Text>().text = "Won: " + playerName;
    }
    public void ChceckVertical()
    {
        for (int i = 0; i < 3; i++)
        {
            if (!buttons[i].interactable && !buttons[i + 3].interactable && !buttons[i + 6].interactable)
            {
                if (buttons[i].GetComponentInChildren<Text>().text == buttons[i + 3].GetComponentInChildren<Text>().text && buttons[i + 3].GetComponentInChildren<Text>().text == buttons[i + 6].GetComponentInChildren<Text>().text)
                {
                    Victory(buttons[i].GetComponentInChildren<Text>().text);
                }
            }
        }
    }
    public void CheckDiagonal()
    {
        // 0, 4, 8
        if (!buttons[0].interactable && !buttons[4].interactable && !buttons[8].interactable)
        {
            if (buttons[0].GetComponentInChildren<Text>().text == buttons[4].GetComponentInChildren<Text>().text && buttons[8].GetComponentInChildren<Text>().text == buttons[4].GetComponentInChildren<Text>().text)
            {
                Victory(buttons[0].GetComponentInChildren<Text>().text);
            }
        }
        //2, 4, 6
        if (!buttons[2].interactable && !buttons[4].interactable && !buttons[6].interactable)
        {
            if (buttons[2].GetComponentInChildren<Text>().text == buttons[4].GetComponentInChildren<Text>().text && buttons[6].GetComponentInChildren<Text>().text == buttons[4].GetComponentInChildren<Text>().text)
            {
                Victory(buttons[2].GetComponentInChildren<Text>().text);
            }
        }
    }
}
