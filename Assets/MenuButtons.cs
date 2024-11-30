using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject menuPanel;
    public ScriptableGameData ScriptableData;

    public void PlayLocalPVP()
    {
        OnButtonClick(GameType.LocalPVP);
    }

    public void PlayVSComp()
    {
        OnButtonClick(GameType.VSComp);
    }

    public void PlayVSAI()
    {
        OnButtonClick(GameType.VSAI);
    }

    public void QuitGame()
    {
        Debug.Log("Exiting Game");
    }

    public void OnButtonClick(GameType eNum)
    {
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
        ScriptableData.curentGameType = eNum;
    }
}
