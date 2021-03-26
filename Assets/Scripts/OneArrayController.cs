using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneArrayController : MonoBehaviour
{
    public int numOfX;
    public int numOfO;

    void FixedUpdate()
    {
        if (numOfX == 3)
        {
            FindObjectOfType<GameManager>().Victory("X");
        }
        else if (numOfO == 3)
        {
            FindObjectOfType<GameManager>().Victory("O");
        }
    }
}
