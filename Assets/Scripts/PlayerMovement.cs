using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public int Lives = 3;
    public int livesDecrease = 1;
    public bool movingLeft;

    public Sprite[] moveAnims;
    public SpriteRenderer anims;

    public GroundCheck groundcheck;
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.AddForce(new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rbody.velocity.y));

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if (groundcheck.touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
