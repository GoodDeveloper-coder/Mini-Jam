using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPool : MonoBehaviour
{
    [SerializeField] List<InkPlayer> players;
    [SerializeField] Material _outline;
    [SerializeField] Material _noOutline;
    private int _selectedPlayer = 0;

    void Start()
    {
        CharacterMovementScript controller = players[_selectedPlayer].GetComponent<CharacterMovementScript>();
        BulletShootScript bullet = players[_selectedPlayer].GetComponent<BulletShootScript>();
        bullet.enabled = true;
        controller.enabled = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SelectNextPlayer();
        }
    }

    void SelectNextPlayer()
    {
        SpriteRenderer renderer = players[_selectedPlayer].GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
           renderer.material = _noOutline;
        }
        CharacterMovementScript controller = players[_selectedPlayer].GetComponent<CharacterMovementScript>();
        BulletShootScript bullet = players[_selectedPlayer].GetComponent<BulletShootScript>();
        controller.enabled = false;
        bullet.enabled = false;

        _selectedPlayer = (_selectedPlayer + 1) % players.Count;
        renderer = players[_selectedPlayer].GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            renderer.material = _outline;
        }

        controller = players[_selectedPlayer].GetComponent<CharacterMovementScript>();
        bullet = players[_selectedPlayer].GetComponent<BulletShootScript>();

        controller.enabled = true;
        bullet.enabled = true;


    }
}
