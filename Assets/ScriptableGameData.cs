using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableGameData : ScriptableObject
{
    public int oddOrEven;

    public int[] WinCheckArray = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int arrayIndex;
    public int arrayValue;

    public int firstColumn;
    public int secondColumn;
    public int thirdColumn;
    public int firstRow;
    public int secondRow;
    public int thirdRow;
    public int firstDiagonal;
    public int secondDiagonal;

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
}
