using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesScript : MonoBehaviour
{
    public GlobalValues GlobalValues;

    public float Team1SpeedUpgradeCost = 10f;
    public float Team2SpeedUpgradeCost = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeamSpeedUpgrade(int TeamID)
    {
        if (TeamID == 1 && GlobalValues.Money1 >= Team1SpeedUpgradeCost)
        {
            GlobalValues.LeftTeamCharactersSpeed += 1f;
            Team1SpeedUpgradeCost += Team1SpeedUpgradeCost / 20;
            GlobalValues.Money1 -= Team1SpeedUpgradeCost;
        }

        if (TeamID == 2 && GlobalValues.Money2 >= Team2SpeedUpgradeCost)
        {
            GlobalValues.RightTeamCharactersSpeed += GlobalValues.LeftTeamCharactersSpeed / 10;
        }
    }



}
