using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public int value = 1;
    public string msgToDisplay;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print(msgToDisplay);

            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                GameController coins = controller.GetComponent<GameController>();
                if(coins != null)
                {
                    coins.CoinCount += value;
                }
            }
            Destroy(gameObject);
        }
    }
}
