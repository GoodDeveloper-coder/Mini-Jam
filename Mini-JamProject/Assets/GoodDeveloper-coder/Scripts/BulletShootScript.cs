using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject BulletPrefabSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Instantiate(BulletPrefab, BulletPrefabSpawnPosition.transform.position, BulletPrefabSpawnPosition.transform.rotation);
        }
        
    }
}
