using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTeamWinScript : MonoBehaviour
{
    public GlobalValues GlobalValues;
    public GameObject RightTeamWinMenu;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            if (GlobalValues.RightTeamCounterOfPoints >= 5)
            {
                RightTeamWinMenu.SetActive(true);
            }
            else
            {
                GlobalValues.RightTeamCounterOfPoints += 1;
            }
        }
    }
    */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            if (GlobalValues.RightTeamCounterOfPoints >= 5)
            {
                RightTeamWinMenu.SetActive(true);
            }
            else
            {
                GlobalValues.RightTeamCounterOfPoints += 1;
            }
        }
    }
}
