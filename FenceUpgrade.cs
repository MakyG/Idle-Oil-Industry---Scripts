using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FenceUpgrade : MonoBehaviour
{
    public GameObject UpgradeSound;
    public GameObject FenceGroup;
    public GameObject BarbedWire;
    public GameObject WatchTower;
    public GameObject WatchTower2;
    public GameObject WatchTower3;
    public GameObject WatchTower4;
    public GameObject Shield;
    public GameObject FenceUpgradeDisplay;

    public static int FenceUpgradeLevel = 0;
    static float UpgradeCost = 30000.0f;
    public float InternalUpgrade;
    bool isFirstBought = false;
    bool isSecondBought = false;
    bool isThirdBought = false;
    bool isFourthBought = false;
    bool isFifthBought = false;
    bool isSixthBought = false;
    bool isSeventhBought = false;

    public void UpgradeFence()
    {
        if (GlobalCash.CashCount >= 620000.0f && isSixthBought == true && isSeventhBought == false)
        {
            GlobalCash.CashCount -= 620000.0f;
            InternalUpgrade = 0;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Max level";
            isSeventhBought = true;
            FenceUpgradeLevel = 7;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 415000.0f && isFifthBought == true && isSixthBought == false)
        {
            GlobalCash.CashCount -= 415000.0f;
            InternalUpgrade = 620000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isSixthBought = true;
            FenceUpgradeLevel = 6;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 200000.0f && isFourthBought == true && isFifthBought == false)
        {
            GlobalCash.CashCount -= 200000.0f;
            InternalUpgrade = 415000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isFifthBought = true;
            FenceUpgradeLevel = 5;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 150000.0f && isThirdBought == true && isFourthBought == false)
        {
            GlobalCash.CashCount -= 150000.0f;
            InternalUpgrade = 200000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isFourthBought = true;
            FenceUpgradeLevel = 4;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 90000.0f && isSecondBought == true && isThirdBought == false)
        {
            GlobalCash.CashCount -= 90000.0f;
            InternalUpgrade = 150000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isThirdBought = true;
            FenceUpgradeLevel = 3;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 40000.0f && isFirstBought == true && isSecondBought == false)
        {
            GlobalCash.CashCount -= 40000.0f;
            InternalUpgrade = 90000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isSecondBought = true;
            FenceUpgradeLevel = 2;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 30000.0f && isFirstBought == false)
        {
            GlobalCash.CashCount -= 30000.0f;
            InternalUpgrade = 40000.0f;
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($" + InternalUpgrade + ")";
            isFirstBought = true;
            FenceUpgradeLevel = 1;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
    }
    public void Update()
    {
        if (FenceUpgradeLevel == 0)
        {
            RandomSabotage.RaidIndex = 1f;
            FenceGroup.SetActive(false);
            BarbedWire.SetActive(false);
            WatchTower.SetActive(false);
            WatchTower2.SetActive(false);
            WatchTower3.SetActive(false);
            WatchTower4.SetActive(false);
            Shield.SetActive(false);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($30000)";
        }
        if (FenceUpgradeLevel == 1)
        {
            RandomSabotage.RaidIndex = 10f;
            FenceGroup.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($40000)";
            isFirstBought = true;
        }
        if (FenceUpgradeLevel == 2)
        {
            RandomSabotage.RaidIndex = 15f;
            BarbedWire.SetActive(true);
            FenceGroup.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($90000)";
            isFirstBought = true;
            isSecondBought = true;
        }
        if (FenceUpgradeLevel == 3)
        {
            RandomSabotage.RaidIndex = 20.0f;
            WatchTower.SetActive(true);
            FenceGroup.SetActive(true);
            BarbedWire.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($150000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
        }
        if (FenceUpgradeLevel == 4)
        {
            RandomSabotage.RaidIndex = 30.0f;
            WatchTower2.SetActive(true);
            WatchTower.SetActive(false);
            FenceGroup.SetActive(true);
            BarbedWire.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($200000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
        }
        if (FenceUpgradeLevel == 5)
        {
            RandomSabotage.RaidIndex = 40.0f;
            WatchTower3.SetActive(true);
            WatchTower2.SetActive(false);
            FenceGroup.SetActive(true);
            BarbedWire.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($415000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
        }
        if (FenceUpgradeLevel == 6)
        {
            RandomSabotage.RaidIndex = 70.0f;
            WatchTower4.SetActive(true);
            WatchTower3.SetActive(false);
            FenceGroup.SetActive(true);
            BarbedWire.SetActive(true);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Security Upgrade ($620000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
            isSixthBought = true;
        }
        if (FenceUpgradeLevel == 7)
        {
            RandomSabotage.RaidIndex = 100.0f;
            Shield.SetActive(true);
            WatchTower4.SetActive(true);
            FenceGroup.SetActive(false);
            BarbedWire.SetActive(false);
            FenceUpgradeDisplay.GetComponent<Text>().text = "Max level";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
            isSixthBought = true;
            isSeventhBought = true;
        }
    }
}
