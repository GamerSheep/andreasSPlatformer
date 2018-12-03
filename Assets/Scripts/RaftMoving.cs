using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftMoving : MonoBehaviour
{
    public Rigidbody2D rbody;
    public int speed;


    // Use this for initialization
    void Start()
    {
        //sätter rbody till Rigidbody2D som scriptet ligger på 
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gör så att den åker framåt
        rbody.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om den kolliderar med objekt med taggen "Ground" så byter den håll
        if(collision.gameObject.tag == "TransportStop")
        {
            speed *= -1;
            print("funkar");
        }
    }
}
