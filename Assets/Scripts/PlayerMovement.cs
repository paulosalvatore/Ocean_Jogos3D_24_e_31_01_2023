using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 150f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        rb.velocity = v * transform.forward * moveSpeed;
        transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);
    }
}
