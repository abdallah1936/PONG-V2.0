using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D _rigidbody;

    public float speed = 200.0f;

    private void Awake() // only gets called one time the entire time
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start() // gets called the very first frame, and just like Awake, only gets called once
    {
        ResetPostion();
    }

        public void ResetPostion()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 directions = new Vector2(x, y);
        _rigidbody.AddForce(directions * this.speed); // this is letting me play with the speed on the unity engine
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}