using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public Text playerScoreText;

    public Text computerscoreText;


    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores()
    {
        _computerScore++;
        this.computerscoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPostion();
        this.computerPaddle.ResetPostion();
        this.ball.ResetPostion();
        this.ball.AddStartingForce();
    }

}

