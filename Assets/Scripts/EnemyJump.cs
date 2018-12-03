using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    [Header("Movement")]
    public float jumpHeight;
    public int touches;
    
    [Header("Rbody and Sprites")]
    public Rigidbody2D rbody;
    public Sprite[] jumpAnim;
    public SpriteRenderer jump;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        jump = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //om fiendens collider inte nuddar något så får den en Jumping Sprite
        if (touches > 0)
        {
            jump.sprite = jumpAnim[1];
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //om fiendens collider kolliderar med ett objekt med taggen
        //EnemyNest så hoppar den och byter håll
        if (col.gameObject.tag == "EnemyNest")
        {
            rbody.velocity = new Vector2(0, jumpHeight);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyNest")
        {
            //när fiendens collider kolliderar med taggen EnemyNest
            //så går int touches upp med en
            touches++;

            //sätter farten på fienden med jumpHeight i y-axeln
            rbody.velocity = new Vector2(0, jumpHeight);

            print("funkar");
        }

        //om fiendens collider kolliderar med taggen EnemyStop 
        //så vrider sig fienden uppochner
        if (collision.gameObject.tag == "EnemyStop")
        {
            transform.rotation = Quaternion.Euler(180, 0, 0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //minskar touches med en när den lämnar EnemyNest
        touches--;
        
    }
}
