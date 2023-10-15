using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeftTeamWinScript : MonoBehaviour
{
    public GlobalValues GlobalValues;
    public GameObject RightTeamWinMenu;

    public TextMeshProUGUI RightCounterOfPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RightCounterOfPoints.text = string.Format($"{GlobalValues.LeftTeamCounterOfPoints}/5");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            if (GlobalValues.LeftTeamCounterOfPoints >= 5)
            {
                RightTeamWinMenu.SetActive(true);     
            }
            else
            {
                GlobalValues.LeftTeamCounterOfPoints += 1;
            }
        }
    }
}
