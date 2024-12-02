using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameReset : MonoBehaviour
{
    public ScriptableGameData ScriptableData;
    public GameObject gamePanel;
    public GameObject menuPanel;

    [SerializeField] private AudioClip buttonClickSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public async void ResetGame()
   {
        audioSource.clip = buttonClickSound;
        audioSource.Play();
        ScriptableData.ResetVariables();
        WhichSign.oddOrEven = 0;
        await Task.Delay(100);
        ScriptableData.continueChecking = true;
    }

    public async void ResetAndGoBackToMenu()
    {
        audioSource.clip = buttonClickSound;
        audioSource.Play();
        ScriptableData.continueChecking = false;
        ScriptableData.ResetScore();
        ResetGame();
        await Task.Delay(100);
        gamePanel.SetActive(false);
        menuPanel.SetActive(true);
        ScriptableData.continueChecking = true;
    }
}
