using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPool : MonoBehaviour
{
    [SerializeField] List<InkPlayer> players;
    [SerializeField] Material _outline;
    [SerializeField] Material _noOutline;
    [SerializeField] int playerID;
    private int _selectedPlayer = 0;

    void Start()
    {
        ToggleCharacterScripts(_selectedPlayer, true);
        ToggleOutline(_selectedPlayer, true);

        for(int i = 0; i < players.Count; i++)
        {
            CharacterMovementScript controller = players[i].GetComponent<CharacterMovementScript>();
            controller.SetPlayerId(playerID);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown((playerID == 1) ? KeyCode.E : KeyCode.Space))
        {
            SelectNextPlayer();
        }
    }

    private void ToggleCharacterScripts(int i, bool on)
    {
        CharacterMovementScript controller = players[i].GetComponent<CharacterMovementScript>();
        BulletShootScript bullet = players[i].GetComponent<BulletShootScript>();
        players[i].ToggleActiveUI(on);
        if(!on)
            controller.MakeIdle();
        controller.enabled = on;
        bullet.enabled = on;

    }

    private void ToggleOutline(int i, bool on)
    {
        SpriteRenderer renderer = players[i].GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            renderer.material = on ? _outline : _noOutline;
        }
    }

    void SelectNextPlayer()
    {
        ToggleOutline(_selectedPlayer, false);
        ToggleCharacterScripts(_selectedPlayer, false);

        _selectedPlayer = (_selectedPlayer + 1) % players.Count;
        
        ToggleOutline(_selectedPlayer, true);
        ToggleCharacterScripts(_selectedPlayer, true);


    }
}
