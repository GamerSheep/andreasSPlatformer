using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombExplode : MonoBehaviour
{
    public Rigidbody2D bomb;
    public Rigidbody2D explosion;
    public float timer = 5;

    // Use this for initialization
    void Start()
    {
        bomb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        WhenExplotion(); 

    }

    void WhenExplotion()
    {
        if (timer < 0)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(explosion);
            }
        }
    }
}
