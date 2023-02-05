using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float graviryModifier = 10f;
    private Rigidbody rb;
    public bool gameOver;

    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= graviryModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.tag.Equals("Obstacle"))
        {
            gameOver = true;
        }
    }
}
