using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLevelController : MonoBehaviour
{
    [Header("Values")]
    public int attackDecider;
    public float timer = 5;
    public int timerControll;
    public bool timerDone;
    public bool attackDone;
    [Header("Rbodys")]
    public Rigidbody2D bomb;
    public Rigidbody2D mouse;
    public Rigidbody2D spike;

    // Use this for initialization
    void Start()
    {
        attackDecider = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackDone == true)
        {
            timer -= 1 * Time.deltaTime;
        }

        if (timer < 0)
        {
            timerDone = true;
            timer = 5;
            attackDone = false;
        }
    }

    void BombExplode()
    {

    }

}
