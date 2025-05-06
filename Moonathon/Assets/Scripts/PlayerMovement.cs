using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 6f;
    public float leftRightSpeed = 4f;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    public float jumpHeight = 1f;
    public float gravity = 4f;

    private float verticalVelocity = 0f;
    private bool isGrounded = true;

    void Update()
    {
        // Move forward constantly
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // Move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed, Space.World);
            }
        }

        // Move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed, Space.World);
            }
        }

        // Jump logic
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(2 * gravity * jumpHeight);
            isGrounded = false;
        }

        // Apply gravity
        if (!isGrounded)
        {
            verticalVelocity -= gravity * Time.deltaTime;
            transform.Translate(Vector3.up * verticalVelocity * Time.deltaTime, Space.World);

            // Check if we've landed (assuming ground is at y = 0)
            if (transform.position.y <= 1.4f)
            {
                Vector3 pos = transform.position;
                pos.y = 1.4f;
                transform.position = pos;
                verticalVelocity = 0f;
                isGrounded = true;
            }
        }
    }
}
