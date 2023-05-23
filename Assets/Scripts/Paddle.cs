using UnityEngine; // imports the Unity engine namespace, giving you access to Unity's APIs.

public class Paddle : MonoBehaviour
// declares a public class named Paddle that inherits from MonoBehaviour, a base class that allows it to be attached to a GameObject as a component.

{
    public float speed = 10.0f; // declares a public floating-point variable named 'speed' and initializes it to 10.0. This represents the speed of the paddle.
    
    protected Rigidbody2D _rigidbody; // declares a protected Rigidbody2D variable named '_rigidbody'. This will hold a reference to the Rigidbody2D component attached to the same GameObject.

    private void Awake() // declares a private method that Unity calls when the script instance is being loaded.
    {
        _rigidbody = GetComponent<Rigidbody2D>(); 
    }
}