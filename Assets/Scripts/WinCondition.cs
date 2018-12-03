using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public string levelToLoad = "SampleScene";
    public string messageToDisplay;
    

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            print(messageToDisplay);
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
