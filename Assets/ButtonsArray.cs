using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsArray : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttonPrefab;
    public GameObject buttonContainer;
    public static string[,] ticTacToeBoard = new string[3, 3];
    void Start()
    {
        float X = 450.5f;
        float Y = 349.5f;
        for (int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                Instantiate(buttonPrefab, new Vector2(X, Y), Quaternion.identity, buttonContainer.transform);
                Y -= 100;
            }
            X += 100;
            Y = 349.5f;
        }
    }
}
