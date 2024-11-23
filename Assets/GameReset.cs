using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameReset : MonoBehaviour
{
    public ScriptableGameData ScriptableData;
   public async void ResetGame()
   {
        ScriptableData.ResetVariables();
        WhichSign.oddOrEven = 0;
        await Task.Delay(100);
        ScriptableData.continueChecking = true;


    }
}
