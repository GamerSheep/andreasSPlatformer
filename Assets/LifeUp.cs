using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : MonoBehaviour
{
    public Rigidbody2D rbody;
    
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                GameController health = controller.GetComponent<GameController>();
                if (health != null)
                {
                    health.HealthCount++;
                    Destroy(gameObject);
                }
            }
        }
    }
}
