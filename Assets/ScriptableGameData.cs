using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System.Threading;
using System;

[CreateAssetMenu]
public class ScriptableGameData : ScriptableObject
{
    public int oddOrEven;

    public Button[] scriptableButtonsArray = new Button[9];

    public int[] WinCheckArray = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int arrayIndex;
    public int arrayValue;

    public bool continueChecking;

    public int firstColumn;
    public int secondColumn;
    public int thirdColumn;
    public int firstRow;
    public int secondRow;
    public int thirdRow;
    public int firstDiagonal;
    public int secondDiagonal;

    public int xScore;
    public int oScore;
    public string outcome;

    public HashSet<int> ButtonsIndexes = new HashSet<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
    private HashSet<int> ButtonsIndexesBackup = new HashSet<int> { 0, 3, 6, 1, 4, 7, 2, 5, 8 };

    public void InitializeBoardButtonScore()
    {
        firstColumn = WinCheckArray[0] + WinCheckArray[1] + WinCheckArray[2];
        secondColumn = WinCheckArray[3] + WinCheckArray[4] + WinCheckArray[5];
        thirdColumn = WinCheckArray[6] + WinCheckArray[7] + WinCheckArray[8];
        firstRow = WinCheckArray[0] + WinCheckArray[3] + WinCheckArray[6];
        secondRow = WinCheckArray[1] + WinCheckArray[4] + WinCheckArray[7];
        thirdRow = WinCheckArray[2] + WinCheckArray[5] + WinCheckArray[8];
        firstDiagonal = WinCheckArray[0] + WinCheckArray[4] + WinCheckArray[8];
        secondDiagonal = WinCheckArray[2] + WinCheckArray[4] + WinCheckArray[6];
    }

    public void InitializeButtonsArray(Button[] buttonArray)
    {
        for(int i = 0; i < buttonArray.Length; i++)
        {
            scriptableButtonsArray[i] = buttonArray[i];
        }
    }

    public void UpdateGameOutcome(TextMeshProUGUI Outcome, TextMeshProUGUI XScore, TextMeshProUGUI OScore)
    {
        Outcome.text = outcome;
        XScore.text = xScore.ToString();
        OScore.text = oScore.ToString();
    }

    public void ResetVariables()
    {
        ResetWinCheckArray();
        oddOrEven = 0;
        arrayIndex = 0;
        arrayValue = 0;
        firstColumn = 0;
        secondColumn = 0;
        thirdColumn = 0;
        firstRow = 0;
        secondRow = 0;
        thirdRow = 0;
        firstDiagonal = 0;
        secondDiagonal = 0;
        outcome = "";
        ButtonsIndexes.UnionWith(ButtonsIndexesBackup);
        DisableOrEnableButtons(true, true);
        continueChecking = false;
    }

    public void DisableOrEnableButtons(bool mode, bool resetMode)
    {
        for (int i = 0; i < scriptableButtonsArray.Length; i++)
        {
            scriptableButtonsArray[i].enabled = mode;

            if (resetMode)
            {
                scriptableButtonsArray[i].GetComponentInChildren<TextMeshProUGUI>().text = "";
            }
        }
        continueChecking = mode;
    }

    public void ResetWinCheckArray()
    {
        for( int i = 0; i < WinCheckArray.Length; i++)
        {
            WinCheckArray[i] = 0;
        }
    }

    public int ChooseRandomIndex()
    {
        int randomIndex;
        randomIndex = UnityEngine.Random.Range(0, ButtonsIndexes.Count);
        Debug.Log("(1)random index:" + randomIndex);
        int chosenIndex = ButtonsIndexes.ElementAt(randomIndex);
        Debug.Log("(1)chosen index: " + chosenIndex);
        ButtonsIndexes.Remove(chosenIndex);
        foreach (int i in ButtonsIndexes)
        {
            Debug.Log("(1)" + i);
        }

        return randomIndex;
    }
    public void RemoveFromHashSet(GameObject gameObject)
    {
        int ChosenIndex = Int32.Parse(gameObject.tag);
        Debug.Log("(2) chosen index:" + ChosenIndex);
        //int playerChosenIndex = ButtonsIndexes.ElementAt(ChosenIndex);
        //Debug.Log("(2) player chosen index:" + playerChosenIndex);
        ButtonsIndexes.Remove(ChosenIndex);
        foreach (int i in ButtonsIndexes)
        {
            Debug.Log("(2)" + i);
        }
    }
}
