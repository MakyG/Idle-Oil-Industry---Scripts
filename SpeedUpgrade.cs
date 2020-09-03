using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUpgrade : MonoBehaviour
{
    public GameObject SpeedIndexObject;
    public GameObject SpeedUpgradeDisplay;
    public GameObject SpeedUpgradeButton;
    public GameObject UpgradeSound;

    public static float SpeedIndex = 1;
    static float SpeedUpgradeCost;
    public float InternalSpeedUpgrade;
    public static int SpeedUpgradeLevel = 1;

    bool isFirstBought = false;
    bool isSecondBought = false;
    bool isThirdBought = false;
    bool isFourthBought = false;
    bool isFifthBought = false;
    bool isSixthBought = false;

    public void UpgradeSpeed()
    {
        if (GlobalCash.CashCount >= 300000 && isSecondBought == true && isThirdBought == false)
        {
            SpeedIndex = 0.4f;
            GlobalCash.CashCount -= 300000;
            //InternalSpeedUpgrade = 700000;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "Max LeveL)";
            isThirdBought = true;
            SpeedUpgradeLevel = 3;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 125000 && isFirstBought == true && isSecondBought == false)
        {
            SpeedIndex = 0.6f;
            GlobalCash.CashCount -= 125000;
            InternalSpeedUpgrade = 300000;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "60% Speed Upgrade ($" + InternalSpeedUpgrade + ")";
            isSecondBought = true;
            SpeedUpgradeLevel = 2;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 50000 && isFirstBought == false)
        {
            SpeedIndex = 0.8f;
            GlobalCash.CashCount -= 15000;
            InternalSpeedUpgrade = 125000;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "40% Speed Upgrade ($" + InternalSpeedUpgrade + ")";
            isFirstBought = true;
            SpeedUpgradeLevel = 1;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
    }

    public void Update()
    {
        if (SpeedUpgradeLevel == 0)
        {
            SpeedIndex = 1;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "20% Speed Upgrade ($50000)";
        }
        if (SpeedUpgradeLevel == 1)
        {
            SpeedIndex = 0.85f;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "40% Speed Upgrade ($125000)";
            isFirstBought = true;
        }
        if (SpeedUpgradeLevel == 2)
        {
            SpeedIndex = 0.7f;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "60% Speed Upgrade ($300000)";
            isFirstBought = true;
            isSecondBought = true;
        }
        if (SpeedUpgradeLevel == 3)
        {
            SpeedIndex = 0.6f;
            SpeedUpgradeDisplay.GetComponent<Text>().text = "Max Level";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
        }
    }
}
