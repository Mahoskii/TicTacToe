using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
            VsAI();
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

    //Minimax Shenanigans

    private async void VsAI()
    {
        UpdateOddOrEven();
        UpdateBoard("X", 88);
        ScriptableData.RemoveFromHashSet(gameObject);
        await Task.Delay(1000);
        if (oddOrEven < 9 && !ScriptableData.isThereAWinner)
        {
            ScriptableData.DisableOrEnableButtons(false, false);
            int chosenIndex = FindBestMove(ScriptableData.WinCheckArray);
            UpdateOddOrEven();
            if (ScriptableData.scriptableButtonsArray[chosenIndex].GetComponentInChildren<TextMeshProUGUI>().text == "")
            {
                ScriptableData.scriptableButtonsArray[chosenIndex].GetComponentInChildren<TextMeshProUGUI>().text = "O";
                FillWinCheckArray(79, true, chosenIndex);
                ScriptableData.InitializeBoardButtonScore();
            }
            ScriptableData.DisableOrEnableButtons(true, false);
        }

    }
    static int FindBestMove(int[] array)
    {
        int bestVal = 0;
        int primeLocation = -1;

        // Traverse all cells, evaluate minimax function  
        // for all empty cells. And return the cell  
        // with optimal value. 
        for (int i = 0; i < array.Length; i++)
        {
            // Check if cell is empty 
            if (array[i] == 0)
            {
                // Make the move 
                array[i] = 79;

                // compute evaluation function for this 
                // move. 
                int moveVal = Minimax(array);

                // Undo the move 
                array[i] = 0;

                // If the value of the current move is 
                // more than the best value, then update 
                // best/ 
                if (moveVal > bestVal)
                {
                    primeLocation = i;
                    bestVal = moveVal;
                }
            }
        }
        Debug.Log($"Prime Location: {primeLocation}");
        return primeLocation;
    }

    private static int Minimax(int[] array)
    {
        //int score = Evaluate(array);

        //// If Maximizer has won the game  
        //// return his/her evaluated score 
        //if (score == 10)
        //    return score;

        //// If Minimizer has won the game  
        //// return his/her evaluated score 
        //if (score == -10)
        //    return score;

        //// If there are no more moves and  
        //// no winner then it is a tie 
        //if (IsMovesLeft(array) == false)
        //    return 0;

        int best = 0;

        // Traverse all cells 
        for (int i = 0; i < array.Length; i++)
        {
            // Check if cell is empty 
            if (array[i] == 0)
            {
                // Make the move 
                array[i] = 79;

                // Call minimax recursively and choose 
                // the maximum value 
                best = Math.Max(best, Minimax(array));

                // Undo the move 
                array[i] = 0;
            }
        }
        Debug.Log($"Best: {best}");
        return best;
    }

    //private static int Evaluate(int[] array)
    //{
    //    // Checking for Rows for X or O victory.
    //    for (int row = 0; row < array.Length; row += 3)
    //    {
    //        if (array[row] == array[row + 1] && array[row + 1] == array[row + 2])
    //        {
    //            if (array[row] == 'X')
    //                return -10;
    //            else if (array[row] == 'O')
    //                return +10;
    //        }
    //    }

    //    // Checking for Columns for X or O victory.
    //    for (int col = 0; col < array.Length / 3; col++)
    //    {
    //        if (array[col] == array[col + 3] && array[col + 3] == array[col + 6])
    //        {
    //            if (array[col] == 'X')
    //                return -10;
    //            else if (array[col] == 'O')
    //                return +10;
    //        }
    //    }

    //    // Checking for Diagonals for X or O victory.
    //    if (array[0] == array[4] && array[4] == array[8])
    //    {
    //        if (array[0] == 'X')
    //            return -10;
    //        else if (array[0] == 'O')
    //            return +10;
    //    }
    //    if (array[2] == array[4] && array[4] == array[6])
    //    {
    //        if (array[2] == 'X')
    //            return -10;
    //        else if (array[2] == 'O')
    //            return +10;
    //    }

    //    // Else if none of them have won then return 0
    //    return 0;
    //}

    //private static bool IsMovesLeft(int[] array)
    //{
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        if (array[i] == 0)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
