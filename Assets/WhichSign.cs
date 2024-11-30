using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        if(ScriptableData.curentGameType == GameType.LocalPVP)
        {
            LocalPVP();
        }
        if (ScriptableData.curentGameType == GameType.VSComp)
        {
            VSComp();
        }
        if (ScriptableData.curentGameType == GameType.VSAI)
        {
            Debug.Log("Coming Soon!");
        }

    }

    public void LocalPVP()
    {
        if (ButtonText.text == "")
        {
            UpdateOddOrEven();

            if (oddOrEven % 2 == 0)
            {
                UpdateBoard("O", 79);
            }
            else
            {
                UpdateBoard("X", 88);
            }
        }
    }

    public async void VSComp()
    {
        if (ButtonText.text == "")
        {
            UpdateOddOrEven();
            UpdateBoard("X", 88);
            ScriptableData.RemoveFromHashSet(gameObject);
            await Task.Delay(1000);
            if (oddOrEven < 9 && !ScriptableData.isThereAWinner)
            {
                AutoFill();
            }
        }
    }

    public void UpdateBoard(string XorO, int ascii)
    {
        ButtonText.text = XorO;
        FillWinCheckArray(ascii, false);
        ScriptableData.InitializeBoardButtonScore();
    }

    public  void AutoFill()
    {
        ScriptableData.DisableOrEnableButtons(false, false);
        int chosenIndex = ScriptableData.ChooseRandomIndex();
        UpdateOddOrEven();
        if (ScriptableData.scriptableButtonsArray[chosenIndex].GetComponentInChildren<TextMeshProUGUI>().text == "")
        {
            ScriptableData.scriptableButtonsArray[chosenIndex].GetComponentInChildren<TextMeshProUGUI>().text = "O";
            FillWinCheckArray(79, true, chosenIndex);
            ScriptableData.InitializeBoardButtonScore();
        }
        ScriptableData.DisableOrEnableButtons(true, false);
    }

    public void UpdateOddOrEven()
    {
        oddOrEven++;
        ScriptableData.oddOrEven = oddOrEven;
    }
 
    public void FillWinCheckArray(int asciiValue, bool vsComp, int chosenIndex = 0)
    {
        ScriptableData.arrayValue = asciiValue; // Ascii Number of X(88) or O(79)
        if (vsComp)
        {
            ScriptableData.arrayIndex = chosenIndex;
        }
        else
        {
            ScriptableData.arrayIndex = Int32.Parse(gameObject.tag); // the tag of the clicked button (0-8)
        }
        ScriptableData.WinCheckArray[ScriptableData.arrayIndex] = ScriptableData.arrayValue;
    }



}
