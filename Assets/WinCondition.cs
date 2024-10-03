using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinCondition :MonoBehaviour
{
    public GameObject buttonPrefab;
    public TextMeshProUGUI ButtonText;
    // Update is called once per frame
    void Update()
    {
        CheckWinner();
    }

    public void CheckWinner()
    {
        if (ButtonsArray.ticTacToeBoard[0, 0] == ButtonsArray.ticTacToeBoard[1,0])
        {
            Debug.Log("they are the same");
        }
        else
        {
            Debug.Log("They are not the same");
        }
    }
}
