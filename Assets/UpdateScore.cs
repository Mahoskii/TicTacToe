using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

public class UpdateScore : MonoBehaviour
{
    public TextMeshProUGUI gameOutcome;
    public TextMeshProUGUI xScoreText;
    public TextMeshProUGUI oScoreText;
    public TextMeshProUGUI updateTitle;
    public ScriptableGameData ScriptableData;

    private void Awake()
    {
        ScriptableData.UpdateGameOutcome(gameOutcome, xScoreText, oScoreText);
    }

    private async void OnEnable()
    {
        await Task.Delay(10);
        if (ScriptableData.curentGameType == GameType.LocalPVP)
        {
            updateTitle.text = "Local PvP";
        }
        if (ScriptableData.curentGameType == GameType.VSComp)
        {
            updateTitle.text = "Player VS Computer";
        }
        if (ScriptableData.curentGameType == GameType.VSAI)
        {
            updateTitle.text = "Player VS AI";
        }
    }

    void Update()
    {
        if (!ScriptableData.continueChecking)
        {
            ScriptableData.UpdateGameOutcome(gameOutcome, xScoreText, oScoreText);
        }
    }
}
