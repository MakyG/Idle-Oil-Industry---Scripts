using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBarrelMine;
    public GameObject AutoBarrelMine1;
    public GameObject AutoBarrelMine2;
    public GameObject AutoBarrelMine3;
    public GameObject AutoBarrelMine4;
    public GameObject AutoBarrelMineMid;
    public GameObject OilPumpHand;
    public GameObject UpgradeDisplay;
    public GameObject UpgradeSound;
    static int UpgradeCost = 4000;
    public int InternalUpgrade;
    public static int UpgradeLevel;
    public bool isFirstBought = false;
    public bool isSecondBought = false;
    public bool isThirdBought = false;
    public bool isFourthBought = false;
    public bool isFifthBought = false;
    public bool isSixthBought = false;

    public void StartAutoBarrel()
    {
        UpgradeCost = InternalUpgrade;

        if (GlobalCash.CashCount >= 560000 && isFifthBought == true && isSixthBought == false)
        {
            AutoBarrelMine3.SetActive(false);
            AutoBarrelMine4.SetActive(true);
            GlobalCash.CashCount -= 560000;
            InternalUpgrade = 0;
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isSixthBought = true;
            UpgradeLevel = 6;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 320000 && isFourthBought == true && isFifthBought == false)
        {
            AutoBarrelMineMid.SetActive(false);
            AutoBarrelMine3.SetActive(true);
            GlobalCash.CashCount -= 320000;
            InternalUpgrade = 560000;
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($" + InternalUpgrade + ")";
            isFifthBought = true;
            UpgradeLevel = 5;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 170000 && isThirdBought == true && isFourthBought == false)
        {
            AutoBarrelMine2.SetActive(false);
            AutoBarrelMineMid.SetActive(true);
            GlobalCash.CashCount -= 170000;
            InternalUpgrade = 320000;
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($" + InternalUpgrade + ")";
            isFourthBought = true;
            UpgradeLevel = 4;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 60000 && isSecondBought == true && isThirdBought == false)
        {
            AutoBarrelMine1.SetActive(false);
            AutoBarrelMine2.SetActive(true);
            GlobalCash.CashCount -= 60000;
            InternalUpgrade = 170000;
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($" + InternalUpgrade + ")";
            isThirdBought = true;
            UpgradeLevel = 3;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 20000 && isFirstBought == true && isSecondBought == false)
        {
            AutoBarrelMine.SetActive(false);
            AutoBarrelMine1.SetActive(true);
            GlobalCash.CashCount -= 20000;
            InternalUpgrade = 60000;
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($" + InternalUpgrade + ")";
            isSecondBought = true;
            UpgradeLevel = 2;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 4000 && isFirstBought == false)
        {
            OilPumpHand.SetActive(true);
            AutoBarrelMine.SetActive(true);
            GlobalCash.CashCount -= 4000;
            InternalUpgrade = 20000;
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($" + InternalUpgrade + ")";
            isFirstBought = true;
            UpgradeLevel = 1;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
    }
    public void Update()
    {
        if (UpgradeLevel == 0)
        {
            AutoBarrelMine.SetActive(false);
            AutoBarrelMine1.SetActive(false);
            AutoBarrelMine2.SetActive(false);
            AutoBarrelMineMid.SetActive(false);
            AutoBarrelMine3.SetActive(false);
            AutoBarrelMine4.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($4000)";
            isFifthBought = false;
            isSecondBought = false;
            isThirdBought = false;
            isFourthBought = false;
            isFifthBought = false;
            isSixthBought = false;
        }
        if (UpgradeLevel == 1)
        {
            AutoBarrelMine.SetActive(true);
            AutoBarrelMine2.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($20000)";
            isFirstBought = true;
        }
        if (UpgradeLevel == 2)
        {
            AutoBarrelMine1.SetActive(true);
            AutoBarrelMine.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($60000)";
            isFirstBought = true;
            isSecondBought = true;
        }
        if (UpgradeLevel == 3)
        {
            AutoBarrelMine1.SetActive(false);
            AutoBarrelMine2.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($170000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
        }
        if (UpgradeLevel == 4)
        {
            AutoBarrelMine2.SetActive(false);
            AutoBarrelMineMid.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($320000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
        }
        if (UpgradeLevel == 5)
        {
            AutoBarrelMineMid.SetActive(false);
            AutoBarrelMine3.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Pump Upgrade ($560000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
        }
        if (UpgradeLevel == 6)
        {
            AutoBarrelMine3.SetActive(false);
            AutoBarrelMine4.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
            isSixthBought = true;
        }
    }
}
