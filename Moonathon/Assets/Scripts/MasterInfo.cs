using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{

    public static int coinCount = 0;
    public static int level = 100;
    public static int easyWinCount = 10;
    public static int mediumWinCount = 20;
    public static int hardWinCount = 40;
    public static bool win = false;

    [SerializeField] GameObject coinDisplay;

    // Update is called once per frame
    void Update()
    {
        if (level == 0)
        {
            coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + coinCount + "/" + easyWinCount;
            if (coinCount >= easyWinCount)
            {
                win = true;
            }
        }
        else if (level == 1)
        {
            coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + coinCount + "/" + mediumWinCount;
            if (coinCount >= mediumWinCount)
            {
                win = true;
            }
        }
        else if (level == 2)
        {
            coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + coinCount + "/" + hardWinCount;
            if (coinCount >= hardWinCount)
            {
                win = true;
            }
        }
        else
        {
            coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + coinCount;
        }

    }
}
