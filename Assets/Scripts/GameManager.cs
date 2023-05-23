using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
    }

    public void ComputerScores()
    {
        _computerScore++;

        this.ball.ResetPostion();
    }

}
