using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTeamWinScript : MonoBehaviour
{
    public GlobalValues GlobalValues;
    public GameObject LeftTeamWinMenu;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            if (GlobalValues.LeftTeamCounterOfPoints >= 5)
            {
                LeftTeamWinMenu.SetActive(true);     
            }
            else
            {
                GlobalValues.LeftTeamCounterOfPoints += 1;
            }
        }
    }
}
