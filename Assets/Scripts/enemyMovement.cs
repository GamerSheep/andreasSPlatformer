using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isMoving = false;
    public bool facingLeft = true;
    public Rigidbody2D enemy;
    public Sprite specific;
    public SpriteRenderer movement;

    // Use this for initialization
    void Start()
    {
        //sätter Rigidbody, spriteRenderer och sprite till objektet som scriptet ligger på
        enemy = GetComponent<Rigidbody2D>();
        movement = GetComponent<SpriteRenderer>();
        specific = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
        //sätter fiendens fart till moveSpeed
        enemy.velocity = new Vector2(-moveSpeed, enemy.velocity.y);

        //byter håll om isMoving är false
        //sätter också tillbaka isMoving till true
        if (isMoving == false)
        {
            moveSpeed *= -1;
            isMoving = true;
        }

        //ett sätt att kolla om fienden kollar till höger eller vänster
        if (moveSpeed < 0)
        {
            facingLeft = false;
        }
        else
        {
            facingLeft = true;
        }

        //byter håll på fienden så att den matchar vilket håll den går åt
        if (facingLeft == false)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //gör så att den byter håll när den går in i en vägg
        if (other.gameObject.tag == "EnemyNest" || other.gameObject.tag == "EnemyStop")
        {
            if (isMoving == true)
            {
                isMoving = false;
            }
            else
            {
                isMoving = true;
            }
        }

    }


}
