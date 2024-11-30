using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameReset : MonoBehaviour
{
    public ScriptableGameData ScriptableData;
    public GameObject gamePanel;
    public GameObject menuPanel;
   public async void ResetGame()
   {
        ScriptableData.ResetVariables();
        WhichSign.oddOrEven = 0;
        await Task.Delay(100);
        ScriptableData.continueChecking = true;
    }

    public async void ResetAndGoBackToMenu()
    {
        ScriptableData.continueChecking = false;
        ScriptableData.ResetScore();
        ResetGame();
        await Task.Delay(100);
        gamePanel.SetActive(false);
        menuPanel.SetActive(true);
        ScriptableData.continueChecking = true;
    }
}
