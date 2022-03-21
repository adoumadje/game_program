using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCH : GameManager
{
    public Ball ball;
    public Racket computerRacket;
    public Racket playerRacket;
    public Text computerScroreText;
    public Text playerScoreText;
    private int _computerScore;
    private int _playerScore;

    public void playerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void computerScores()
    {
        _computerScore++;
        computerScroreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        computerRacket.ResetPosition();
        playerRacket.ResetPosition();
        ball.AddStartingForce();
    }
}
