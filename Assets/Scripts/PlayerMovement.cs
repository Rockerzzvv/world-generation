using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController control;
    public float speed = 11f;
    public float gravity = -9.8f;
    public Transform GrounCheck;
    public float GroundDistane = 0.4f;
    public LayerMask groundmask;
    public float jumpvelocity = 5f;

    Vector3 Velocity;
    bool isGrounded;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Break();
        }
        isGrounded = Physics.CheckSphere(GrounCheck.position, GroundDistane, groundmask);

        if (isGrounded && Velocity.y < 0)
        {
            Velocity.y = -3f;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        control.Move(move * speed * Time.deltaTime);
        Velocity.y += gravity * Time.deltaTime;

        control.Move(Velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Velocity.y = jumpvelocity;
        }
    }
}
