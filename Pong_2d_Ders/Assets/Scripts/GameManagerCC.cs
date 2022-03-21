using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCC : GameManager
{
    public Ball ball;
    public Racket computer1Racket;
    public Racket computer2Racket;
    public Text computer1ScroreText;
    public Text computer2ScoreText;
    private int _computer1Score;
    private int _computer2Score;

    public void computer1Scores()
    {
        _computer1Score++;
        computer1ScroreText.text = _computer1Score.ToString();
        ResetRound();
    }

    public void computer2Scores()
    {
        _computer2Score++;
        computer2ScoreText.text = _computer2Score.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        computer1Racket.ResetPosition();
        computer2Racket.ResetPosition();
        ball.AddStartingForce();
    }
}
