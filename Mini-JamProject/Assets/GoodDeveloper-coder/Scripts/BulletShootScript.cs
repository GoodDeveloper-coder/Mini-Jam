using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject BulletPrefabSpawnPosition;

    public GlobalValues GlobalValues;

    public int TeamID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TeamID == 1)
        {
            if (Input.GetKeyDown("r"))
            {
                if (TeamID == 1)
                {
                    if (GlobalValues.LeftTeamShootedTimes >= 3)
                    {
                        StartCoroutine(ShootingReloadTime());
                    }
                    else
                    {
                        Instantiate(BulletPrefab, BulletPrefabSpawnPosition.transform.position, BulletPrefabSpawnPosition.transform.rotation);
                        GlobalValues.LeftTeamShootedTimes++;
                    }
                }
            }
        }

        if (TeamID == 2)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                if (GlobalValues.RightTeamShootedTimes >= 3)
                {
                    StartCoroutine(ShootingReloadTime());
                }
                else
                {
                    Instantiate(BulletPrefab, BulletPrefabSpawnPosition.transform.position, BulletPrefabSpawnPosition.transform.rotation);
                    GlobalValues.RightTeamShootedTimes++;
                }
            }
        }
    }   


    IEnumerator ShootingReloadTime()
    {
        yield return new WaitForSeconds(3f);

        if (TeamID == 1)
        {
            GlobalValues.LeftTeamShootedTimes = 0;
        }

        if (TeamID == 2)
        {
            GlobalValues.RightTeamShootedTimes = 0;
        }
    }
}
