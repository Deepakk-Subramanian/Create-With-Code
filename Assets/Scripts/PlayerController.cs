using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f ;
    private float horizontalInput;
    private float verticalInput;
    private float turnspeed = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (verticalInput * speed * Time.deltaTime));
        transform.Rotate(Vector3.up * ( turnspeed* horizontalInput * Time.deltaTime));
    }
}
