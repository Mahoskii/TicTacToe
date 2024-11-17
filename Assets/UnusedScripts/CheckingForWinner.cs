using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class CheckingForWinner : MonoBehaviour
{
    public TextMeshProUGUI Wintxt;
    GameObject ContainWin;
    private void Start()
    {
        ContainWin = GameObject.FindGameObjectWithTag("WinContain");
    }
    public void CheckWinner()
    {
        
        if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);

            if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
                Debug.Log("Im the chosen!");
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
                Debug.Log("No you are not!");
            }
        }
        if (ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 2].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
        if (ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            Instantiate(Wintxt, ContainWin.transform);
            if (ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == "X")
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "X is the Winner!";
            }
            else
            {
                Wintxt.GetComponent<TextMeshProUGUI>().text = "O is the Winner!";
            }
        }
    }
}
