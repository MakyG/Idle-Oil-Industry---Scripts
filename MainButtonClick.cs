using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public GameObject HandPumpStick;
    public GameObject OilTry;
    //public GameObject ClickIndexObject;
    public GameObject ClickUpgradeDisplay;
    public GameObject ClickUpgradeButton;
    public GameObject UpgradeSound;

    public int ClickIndex = 1;
    static float ClickUpgradeCost;
    public float InternalClickUpgrade;
    public static int ClickUpgradeLevel = 0;

    bool CanMine = true;
    bool isFirstBought = false;
    bool isSecondBought = false;
    bool isThirdBought = false;
    bool isFourthBought = false;
    bool isFifthBought = false;
    bool isSixthBought = false;

    public void UpgradeClick()
    {
        if (GlobalCash.CashCount >= 330000 && isFifthBought == true && isSixthBought == false)
        {
            ClickIndex = 7;
            GlobalCash.CashCount -= 330000;
            InternalClickUpgrade = 0;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Max level";
            isSixthBought = true;
            ClickUpgradeLevel = 6;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 200000 && isFourthBought == true && isFifthBought == false)
        {
            ClickIndex = 6;
            GlobalCash.CashCount -= 200000;
            InternalClickUpgrade = 330000;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($" + InternalClickUpgrade + ")";
            isFifthBought = true;
            ClickUpgradeLevel = 5;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 90000 && isThirdBought == true && isFourthBought == false)
        {
            ClickIndex = 5;
            GlobalCash.CashCount -= 90000;
            InternalClickUpgrade = 200000;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($" + InternalClickUpgrade + ")";
            isFourthBought = true;
            ClickUpgradeLevel = 4;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 40000 && isSecondBought == true && isThirdBought == false)
        {
            ClickIndex = 4;
            GlobalCash.CashCount -= 40000;
            InternalClickUpgrade = 90000;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($" + InternalClickUpgrade + ")";
            isThirdBought = true;
            ClickUpgradeLevel = 3;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 15000 && isFirstBought == true && isSecondBought == false)
        {
            ClickIndex = 3;
            GlobalCash.CashCount -= 15000;
            InternalClickUpgrade = 40000;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($" + InternalClickUpgrade + ")";
            isSecondBought = true;
            ClickUpgradeLevel = 2;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
        if (GlobalCash.CashCount >= 7000 && isFirstBought == false)
        {
            ClickIndex = 2;
            GlobalCash.CashCount -= 7000;
            InternalClickUpgrade = 15000;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($" + InternalClickUpgrade + ")";
            isFirstBought = true;
            ClickUpgradeLevel = 1;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
    }

    public void ClickTheButton ()
    {
        if (CanMine == true)
        {
            GlobalBarrel.BarrelCount += (ClickIndex * GoldenRain.GoldIndex);
            HandPumpStick.GetComponent<Animation>().Play("HandPumpAnim");
            OilTry.SetActive(true);
            OilTry.GetComponent<Animation>().Play("OilTryAnim");
            StartCoroutine(MineTheOil());
        }
    }

    IEnumerator MineTheOil()
    {
        CanMine = false;
        yield return new WaitForSeconds(0.03f);
        CanMine = true;
    }

    public void Update()
    {
        if (ClickUpgradeLevel == 0)
        {
            ClickIndex = 1;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($7000)";
        }
        if (ClickUpgradeLevel == 1)
        {
            ClickIndex = 2;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($15000)";
            isFirstBought = true;
        }
        if (ClickUpgradeLevel == 2)
        {
            ClickIndex = 3;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($40000)";
            isFirstBought = true;
            isSecondBought = true;
        }
        if (ClickUpgradeLevel == 3)
        {
            ClickIndex = 4;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($90000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
        }
        if (ClickUpgradeLevel == 4)
        {
            ClickIndex = 5;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($200000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
        }
        if (ClickUpgradeLevel == 5)
        {
            ClickIndex = 6;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Click Upgrade ($330000)";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
        }
        if (ClickUpgradeLevel == 6)
        {
            ClickIndex = 6;
            ClickUpgradeDisplay.GetComponent<Text>().text = "Max level";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            isFourthBought = true;
            isFifthBought = true;
            isSixthBought = true;
        }
    }
}
