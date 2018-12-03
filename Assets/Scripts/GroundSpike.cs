using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpike : MonoBehaviour
{
    public float timerDown = 2;
    public float timerUp = 5;
    public bool spikesUp = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spikesUp == false)
        {
            transform.Translate(new Vector2(-1.04f, -1.06f));
            timerUp -= 1 * Time.deltaTime;
        }

        if (timerUp < 0)
        {
            transform.Translate(new Vector2(-1.04f, 0.44f));
            timerDown -= 1 * Time.deltaTime;
            spikesUp = true;
        }
    }
}
