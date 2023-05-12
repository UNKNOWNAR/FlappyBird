using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
