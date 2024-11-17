using System;
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
    public static int oddOrEven;
    public ScriptableGameData ScriptableData;

    public void ButtonPressed()
    {

        if (ButtonText.text == "")
        {
            oddOrEven++;
            ScriptableData.oddOrEven = oddOrEven;

            if (oddOrEven % 2 == 0)
            {
                ButtonText.text = "O";
                FillWinCheckArray(79);
                ScriptableData.InitializeBoardButtonScore();
            }
            else
            {
                ButtonText.text = "X";
                FillWinCheckArray(88);
                ScriptableData.InitializeBoardButtonScore();
            }
        }
    }

    public void FillWinCheckArray(int asciiValue)
    {
        ScriptableData.arrayValue = asciiValue; // Ascii Number of X(88) or O(79)
        ScriptableData.arrayIndex = Int32.Parse(gameObject.tag); // the tag of the clicked button (0-8)
        ScriptableData.WinCheckArray[ScriptableData.arrayIndex] = ScriptableData.arrayValue;
    }
}
