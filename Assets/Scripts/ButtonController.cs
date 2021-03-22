using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public string text;

    void Start()
    {

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
}
