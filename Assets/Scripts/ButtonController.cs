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
        text = this.gameObject.transform.GetChild(0).GetComponent<Text>().text;
        if (text.Length != 0)
        {
            if (text == "X")
            {
                GetComponentInParent<OneArrayController>().numOfX++;
            }
            else
            {
                GetComponentInParent<OneArrayController>().numOfO++;
            }
        }
    }
    public void SetText()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        text = gm.round;
        button.GetComponentInChildren<Text>().text = text;
        button.interactable = false;
        gm.ChangePlayerName();
    }
}
