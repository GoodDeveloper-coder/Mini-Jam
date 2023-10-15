using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefabScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float BulletSpeed;

    public Animator anim;

    public Collider2D collider2D;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * BulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InkCharacter")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Wall")
        {
            anim.SetBool("IsIntersectedWithAll", true);
            rb.velocity = transform.right * 0;
            collider2D.enabled = false;
        }
    }
}
