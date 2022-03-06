using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void playerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        resetRound();
    }

    public void computerScores()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        resetRound();
    }

    private void resetRound()
    {
        playerPaddle.resetPosition();
        computerPaddle.resetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}
