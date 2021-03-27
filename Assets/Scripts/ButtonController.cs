using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public string text;
    private Button button;

    void Start()
    {
        button = this.gameObject.GetComponent<Button>();
    }
    void FixedUpdate()
    {
        
    }
    public void SetText()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        text = gm.round;
        if (text == "X")
        {
            GetComponentInParent<OneArrayController>().numOfX++;
        }
        else
        {
            GetComponentInParent<OneArrayController>().numOfO++;
        }
        button.GetComponentInChildren<Text>().text = text;
        button.interactable = false;
        gm.ChceckVertical();
        gm.CheckDiagonal();
        gm.ChangePlayerName();
    }
}
