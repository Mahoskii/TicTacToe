using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class WinLoseOrTie : MonoBehaviour
{
    public ScriptableGameData ScriptableData;
    public Button[] buttonsArray = new Button[9];

    private void Awake()
    {
        ScriptableData.InitializeButtonsArray(buttonsArray);
        ScriptableData.DisableOrEnableButtons(true, false);
    }

    void Update()
    {
        if (ScriptableData.oddOrEven >= 5 && ScriptableData.continueChecking)
        {
            CheckWinLoseOrTie();
        }
        if (ScriptableData.oddOrEven == 9 && ScriptableData.continueChecking)
        {
            ScriptableData.DisableOrEnableButtons(false, false);
            ScriptableData.outcome = "It's a tie!";
        }
    }

    private void CheckWinLoseOrTie()
    {
        if(ScriptableData.firstColumn > 200 || ScriptableData.secondColumn > 200 || ScriptableData.thirdColumn > 200 ||
           ScriptableData.firstRow > 200 || ScriptableData.secondRow > 200 || ScriptableData.thirdRow > 200 ||
           ScriptableData.firstDiagonal > 200 || ScriptableData.secondDiagonal > 200)
        {
            if(ScriptableData.firstColumn == 237 || ScriptableData.secondColumn == 237 || ScriptableData.thirdColumn == 237 ||
           ScriptableData.firstRow == 237 || ScriptableData.secondRow == 237 || ScriptableData.thirdRow == 237 ||
           ScriptableData.firstDiagonal == 237 || ScriptableData.secondDiagonal == 237)
            {
                UponWinning("O is the Winner!!", false);
            }

            if (ScriptableData.firstColumn == 264 || ScriptableData.secondColumn == 264 || ScriptableData.thirdColumn == 264 ||
                ScriptableData.firstRow == 264 || ScriptableData.secondRow == 264 || ScriptableData.thirdRow == 264 ||
                ScriptableData.firstDiagonal == 264 || ScriptableData.secondDiagonal == 264)
            {
                UponWinning("X is the Winner!!", true);
            }
        }
    }

    public void UponWinning(string winMessage, bool Xwinner)
    {
        ScriptableData.DisableOrEnableButtons(false, false);
        ScriptableData.outcome = winMessage;
        ScriptableData.isThereAWinner = true;
        if (Xwinner)
        {
            ScriptableData.xScore++;
        }
        else
        {
            ScriptableData.oScore++;
        }
        
    }


}
