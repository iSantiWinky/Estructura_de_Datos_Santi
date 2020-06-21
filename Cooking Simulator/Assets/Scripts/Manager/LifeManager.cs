using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LifeManager : MonoBehaviour
{
    public static int lives = 3;
    Text livesText;

    private void Start()
    {
        livesText = GetComponent<Text>();
        lives = 3;
    }

    void Update()
    {
        livesText.text = "Lives: " + lives.ToString();
    }
}
