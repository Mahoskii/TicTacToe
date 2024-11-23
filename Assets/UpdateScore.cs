using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TextMeshProUGUI gameOutcome;
    public TextMeshProUGUI xScoreText;
    public TextMeshProUGUI oScoreText;
    public ScriptableGameData ScriptableData;

    private void Awake()
    {
        ScriptableData.UpdateGameOutcome(gameOutcome, xScoreText, oScoreText);
    }

    void Update()
    {
        if (!ScriptableData.continueChecking)
        {
            ScriptableData.UpdateGameOutcome(gameOutcome, xScoreText, oScoreText);
        }
    }
}
