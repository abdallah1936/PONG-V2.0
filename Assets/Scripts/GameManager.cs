using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public Text playerScoreText;

    public Text computerscoreText;

    public Text gameEndText;

    private int _playerScore;

    private int _computerScore;

    private int scoreLimit = 10; 

    private bool isGameActive = true;

    public void PlayerScores()
    {
        if (isGameActive)
        {
            _playerScore++;
            this.playerScoreText.text = _playerScore.ToString();
            CheckScore();
            ResetRound();
        }
    }
    public void ComputerScores()
    {
        if (isGameActive)
        {
            _computerScore++;
            this.computerscoreText.text = _computerScore.ToString();
            CheckScore();
            ResetRound();
        }
    }

    private void CheckScore()
    {
        if (_playerScore >= scoreLimit)
        {
            gameEndText.text = "YOU WON!!!";
            isGameActive = false;
            Time.timeScale = 0;
        }
        else if (_computerScore >= scoreLimit)
        {
            gameEndText.text = "You lost, try again";
            isGameActive = false;
            Time.timeScale = 0;

        }
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPostion();
        this.computerPaddle.ResetPostion();
        this.ball.ResetPostion();
        this.ball.AddStartingForce();
    }

    public void StartGame()
    {
        _playerScore = 0;
        _computerScore = 0;
        gameEndText.text = "";
        this.playerScoreText.text = _playerScore.ToString();
        this.computerscoreText.text = _computerScore.ToString();
        Time.timeScale = 1;
        ResetRound();
    }

    public void RestartGame()
    {
        _playerScore = 0;
        _computerScore = 0;
        gameEndText.text = "";
        this.playerScoreText.text = _playerScore.ToString();
        this.computerscoreText.text = _computerScore.ToString();
        this.playerPaddle.ResetPostion();
        this.computerPaddle.ResetPostion();
        this.ball.ResetPostion();
        this.ball.AddStartingForce();
        Time.timeScale = 1;
        isGameActive = true;
        ResetRound();
    }

}

