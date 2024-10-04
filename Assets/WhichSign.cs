using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WhichSign : MonoBehaviour
{
    // on button click, if the text is empty, then generate either X or O.
    // X always starts. one even numbers generate O on the chosen button and on odd numbers generate X. there will be a total of 9 buttons.
    public TextMeshProUGUI ButtonText;
    private static int OddOrEven;

    //public GameObject WinTextContainer;
    //public TextMeshProUGUI WinText;

    private void Start()
    {

    }

    public void ButtonPressed()
    {

        if (ButtonText.GetComponent<TextMeshProUGUI>().text == "")
        {
            OddOrEven++;

            if (OddOrEven % 2 == 0)
            {
                ButtonText.GetComponent<TextMeshProUGUI>().text = "O";
                CheckWinner("O");
            }
            else
            {
                ButtonText.GetComponent<TextMeshProUGUI>().text = "X";
                CheckWinner("X");
            }
        }
    }

    public void CheckWinner(string sign)
    {
        if (ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
            ||
           ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text != ""
            ||
           ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 2].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text != ""
           ||
           ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
           ||
           ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
           ||
           ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
           ||
           ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[2, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[0, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
           ||
           ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[1, 1].GetComponentInChildren<TextMeshProUGUI>().text == ButtonsArray.ticTacToeBoard[0, 2].GetComponentInChildren<TextMeshProUGUI>().text && ButtonsArray.ticTacToeBoard[2, 0].GetComponentInChildren<TextMeshProUGUI>().text != ""
            )
        {
            //Instantiate(WinText, new Vector2(650.5f, 159.5f), Quaternion.identity, WinTextContainer.transform);
            //WinText.text = "We have a winner!";
            Debug.Log($"{sign} is the winner!");
            return;
        }

    }
}
