using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed ;
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed = 15f;

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
