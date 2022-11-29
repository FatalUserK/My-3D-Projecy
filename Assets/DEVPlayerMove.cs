using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DEVPlayerMove : MonoBehaviour
{

    public CharacterController controller;

    public float baseSpeed = 12;
    public float speedModifier = 1;

    public float baseJump = 3;
    public float jumpModifier = 1;

    public bool debugMovement = true;
    bool flyMode = false;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public float gravity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Vertical");
        Vector3 move;
        if (debugMovement == false)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < -2)
            {
                velocity.y = -2;
                controller.stepOffset = 0.7f;
            }
            else { controller.stepOffset = 0.2f; }


            

            move = transform.right * x + transform.forward * z;


            if (Input.GetButtonDown("Jump") && isGrounded) { velocity.y = Mathf.Sqrt(baseJump * jumpModifier * gravity); }

            velocity.y -= gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
            controller.Move(move * baseSpeed * speedModifier * Time.deltaTime);
        }
        else
        {
            controller.Move((Vector3.right * x + Vector3.forward * z) * Time.deltaTime);
        }


    }
}
