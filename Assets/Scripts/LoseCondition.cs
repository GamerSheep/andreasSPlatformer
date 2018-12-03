using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{


    public int damage = 1;
    public string levelToLoad = "SampleScene";
    public string messageToDisplay;


    private void OnTriggerEnter2D(Collider2D col)
    {
        //om objektet stöter på spelaren så går spelarens liv ner med 1
        if (col.gameObject.tag == "Player")
        {
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                GameController health = controller.GetComponent<GameController>();
                if (health != null)
                {
                    health.HealthCount--;
                    print(messageToDisplay);
                    if(health.HealthCount < 1)
                    {
                        SceneManager.LoadScene(levelToLoad);
                        print(messageToDisplay);
                    }
                }
            }
        }

    }

    
}
