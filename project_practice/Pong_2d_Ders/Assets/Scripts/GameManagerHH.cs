using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerHH : GameManager
{
    public Ball ball;
    public Racket player1Racket;
    public Racket player2Racket;
    public Text player1ScoreText;
    public Text player2ScoreText;
    private int _player1Score;
    private int _player2Score;

    public void player1Scores()
    {
        _player1Score++;
        player1ScoreText.text = _player1Score.ToString();
        ResetRound();
    }

    public void player2Scores()
    {
         _player2Score++;
        player2ScoreText.text = _player1Score.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        player1Racket.ResetPosition();
        player2Racket.ResetPosition();
        ball.AddStartingForce();
    }
}
