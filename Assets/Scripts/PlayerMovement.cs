using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    public bool flipH;
    public bool flipV;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var h = Input.GetAxis("Horizontal") * speed * (flipH ? -1 : 1);
        var v = Input.GetAxis("Vertical") * speed * (flipV ? -1 : 1);

        rb.velocity = new Vector3(v, rb.velocity.y, h);
    }
}
