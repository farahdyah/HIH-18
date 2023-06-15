using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;
    public PlayerMovement playerMovement;
    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.movement==new Vector2(-1,0)){
            animator.Play("leftMove");
        }
        if(playerMovement.movement==new Vector2(0,1)){
            animator.Play("UpMove");
        }
        if(playerMovement.movement==new Vector2(0,-1)){
            animator.Play("downMove");
        }
        if(playerMovement.movement==new Vector2(1,0)){
            animator.Play("rightMove");
        }
        if(playerMovement.movement == Vector2.zero){
            animator.Play("FrontIdle");
        }
    }
}
