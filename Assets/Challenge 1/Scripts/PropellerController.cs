using UnityEngine;

public class PropellerController : MonoBehaviour
{
    private float _rotationSpeed = 2000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * _rotationSpeed);
    }
}
