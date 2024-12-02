using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject menuPanel;
    public ScriptableGameData ScriptableData;

    [SerializeField] private AudioClip buttonClickSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayLocalPVP()
    {
        PlaySFX();
        OnButtonClick(GameType.LocalPVP);
    }

    public void PlayVSComp()
    {
        PlaySFX();
        OnButtonClick(GameType.VSComp);
    }

    public void PlayVSAI()
    {
        PlaySFX();
        OnButtonClick(GameType.VSAI);
    }

    public void QuitGame()
    {
        PlaySFX();
        Debug.Log("Exiting Game");
    }

    public void OnButtonClick(GameType eNum)
    {
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
        ScriptableData.curentGameType = eNum;
    }

    private void PlaySFX()
    {
        audioSource.clip = buttonClickSound;
        audioSource.Play();
    }
}
