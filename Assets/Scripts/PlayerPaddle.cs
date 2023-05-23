using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _directions; // keep track of the paddle direction

    private void Update() // unity calls this automatically, it calls it every single frame if the game 
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            _directions = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            _directions = Vector2.down;
        } else {
            _directions = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_directions.sqrMagnitude != 0) {
            _rigidbody.AddForce(_directions * this.speed);
        }
    }
}