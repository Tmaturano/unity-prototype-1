using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20.0f;
    private float _turnSpeed = 45.0f;
    private float _horizontalInput;
    private float _forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Edit/Project Settings -> Input Manager / Axes
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward on vertical input
        // Time.deltaTime updates the position over time instead of once every frame
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
