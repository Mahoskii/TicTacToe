using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class WinLoseOrTie : MonoBehaviour
{
    public ScriptableGameData ScriptableData;

    void Update()
    {
        if (ScriptableData.oddOrEven >= 5)
        {
            CheckWinLoseOrTie();
        }
        if (ScriptableData.oddOrEven == 9)
        {
            Debug.Log("It's a Tie!");
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
                Debug.Log("O is the Winner");
            }

            if (ScriptableData.firstColumn == 264 || ScriptableData.secondColumn == 264 || ScriptableData.thirdColumn == 264 ||
                ScriptableData.firstRow == 264 || ScriptableData.secondRow == 264 || ScriptableData.thirdRow == 264 ||
                ScriptableData.firstDiagonal == 264 || ScriptableData.secondDiagonal == 264)
            {
                Debug.Log("X is the Winner");
            }
        }
    }
}
