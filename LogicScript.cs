using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    [ContextMenu("Reset Score")]
    public void resetScore()
    {
        playerScore=0;
        scoreText.text = playerScore.ToString();
    }
}
