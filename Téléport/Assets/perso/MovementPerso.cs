using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPerso : MonoBehaviour

{
    [Range(0.0001f, 1f)]
    public float speed = 0.01f;

    [Range(10, 500)]
    public float jumpForce = 250;

    public Rigidbody rgdb;
    public Transform raycastOrigin;



    public void Move(Vector3 direction)
    {
        transform.Translate(direction * speed);
    }

    public void Jump()
    {
        var isGrounded = Physics.Raycast(raycastOrigin.position, Vector3.down, 0.1f);
        if (isGrounded)
        {
            rgdb.AddForce(Vector3.up * jumpForce);
        }
    }
}
