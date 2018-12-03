using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int CoinCount;
    public TextMeshProUGUI coinCount;
    public int HealthCount = 3;
    public TextMeshProUGUI healthText;

    private void Update()
    {
        coinCount.text = string.Format("Coins : {0}", CoinCount);
        healthText.text = string.Format("Lives : {0}", HealthCount);
    }

}
