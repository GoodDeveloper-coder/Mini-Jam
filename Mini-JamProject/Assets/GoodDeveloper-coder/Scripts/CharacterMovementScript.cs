using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] int playerID = 1;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public int GetPlayerId()
    {
        return playerID;
    }

    public void SetPlayerId(int id)
    {
        playerID = id;
    }

    public void MakeIdle()
    {
        animator.SetBool("IsIdle", false);
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal_P" + playerID);
        float vertical = Input.GetAxis("Vertical_P" + playerID);

        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);


        if (movement.magnitude > 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

}
