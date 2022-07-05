using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _speed = 15.0f;
    private float _rotationSpeed = 100.0f;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * _rotationSpeed * _verticalInput);
    }
}
