using UnityEngine;

public class Bouncysurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal; // GetContact gets the contact points of the collision, the (0) means that we only care about the first contact; the first index.
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
