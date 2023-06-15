using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Animator animator;
    private bool isWalking = false;
    private bool isJumping = false;

    private void Update()
    {
        // Handle input for character movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if character is walking
        if (horizontalInput != 0 || verticalInput != 0)
        {
            if (!isWalking)
            {
                StartWalking();
            }
        }
        else
        {
            if (isWalking)
            {
                StopWalking();
            }
        }

        // Check if character should jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void StartWalking()
    {
        isWalking = true;
        animator.SetBool("IsWalking", true);
    }

    private void StopWalking()
    {
        isWalking = false;
        animator.SetBool("IsWalking", false);
    }

    private void Jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            animator.SetTrigger("Jump");
        }
    }

    // Called by animation event
    public void OnJumpComplete()
    {
        isJumping = false;
    }
}
