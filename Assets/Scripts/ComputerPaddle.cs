using UnityEngine;

public class ComputerPaddle : Paddle //declares a public class named ComputerPaddle that inherits from the Paddle class.
{

  public Rigidbody2D ball; //declares a public Rigidbody2D variable named 'ball'. This will reference the ball's Rigidbody2D component.

  private void FixedUpdate() //declares a private method that Unity calls every fixed framerate frame.
  {
      if (this.ball.velocity.x > 0.0f) // If the ball is moving to the right
      {
        if (this.ball.position.y > this.transform.position.y) 
        // If the ball is above the paddle
        {
          _rigidbody.AddForce(Vector2.up * this.speed);// move the paddle up.
        } else if (this.ball.position.y < this.transform.position.y) // If the ball is below the paddle
        {
          _rigidbody.AddForce(Vector2.down * this.speed);// move the paddle down.

        }
      }
      else
      // This next if-else block determines whether the paddle should move up or down based on its position relative to the center of the play area.
      {
        if (this.transform.position.y > 0.0f) {
          _rigidbody.AddForce(Vector2.down * this.speed);
        } else if (this.transform.position.y < 0.0f) {
          _rigidbody.AddForce(Vector2.up * this.speed);
        }
      }
  }
}

// my attempt at making an AI
