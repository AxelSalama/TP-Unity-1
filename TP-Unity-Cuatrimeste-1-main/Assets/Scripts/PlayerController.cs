using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 jumpspeed;

    bool isGrounded = false;
    Rigidbody rb;

    void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = jumpspeed;
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0,0,0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0,0,-0.1f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    void OnTriggerExit(Collider gameArea)
    {
        transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }
}
