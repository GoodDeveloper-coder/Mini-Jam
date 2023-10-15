using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] int playerID = 1;

    public int GetPlayerId()
    {
        return playerID;
    }

    public void SetPlayerId(int id)
    {
        playerID = id;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal_P" + playerID);
        float vertical = Input.GetAxis("Vertical_P" + playerID);

        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

}
