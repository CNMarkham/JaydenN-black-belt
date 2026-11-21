using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public bool canJump;
    public Rigidbody rb;
    public LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = transform.forward * vertical * speed + transform.right * horizontal * speed + Vector3.up * rb.velocity.y;

        //Jump
        canJump = Physics.BoxCast(transform.position, Vector3.one/2, Vector3.down, Quaternion.identity, 2f,ground);
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }


    }
}
