using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WhichSign : MonoBehaviour
{
    // on button click, if the text is empty, then generate either X or O.
    // X always starts. one even numbers generate O on the chosen button and on odd numbers generate X. there will be a total of 9 buttons.
    public TextMeshProUGUI ButtonText;
    private static int OddOrEven;

    private void Start()
    {

    }

    public void ButtonPressed()
    {
        
        if(ButtonText.GetComponent<TextMeshProUGUI>().text == "")
        {
            OddOrEven++;

            if (OddOrEven % 2 == 0)
            {
                ButtonText.GetComponent<TextMeshProUGUI>().text = "O";
                
            }
            else
            {
                ButtonText.GetComponent<TextMeshProUGUI>().text = "X";
                
            }
        }
    }
    
}
