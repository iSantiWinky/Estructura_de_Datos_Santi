using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    public static int clientScore;

    private void Start()
    {
        text = GetComponent<Text>();
        clientScore = 0;
    }

    private void Update()
    {
        text.text = "SCORE: " +  clientScore.ToString();
    }

}
