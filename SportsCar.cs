using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SportsCar : MonoBehaviour
{
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public GameObject Car5;
    public GameObject Car6;
    public GameObject Car7;
    public GameObject UpgradeDisplay;
    public GameObject UpgradeSound;
    public GameObject MazdaSound;
    public GameObject AstonSound;
    public GameObject PorscheSound;
    public GameObject ChevroletSound;
    public GameObject MercedesSound;
    public GameObject Honda2Sound;
    public GameObject BugattiSound;

    static int UpgradeCost = 100000;
    public int InternalUpgrade;
    public static int UpgradeLevel;
    bool isFirstBought = false;
    bool isSecondBought = false;
    bool isThirdBought = false;
    bool isFourthBought = false;
    bool isFifthBought = false;
    bool isSixthBought = false;
    bool isSeventhBought = false;

    public void ClickMazda()
    {
        MazdaSound.GetComponent<AudioSource>().Play();
    }
    public void ClickAston()
    {
        AstonSound.GetComponent<AudioSource>().Play();
    }
    public void ClickPorsche()
    {
        PorscheSound.GetComponent<AudioSource>().Play();
    }
    public void ClickChevrolet()
    {
        ChevroletSound.GetComponent<AudioSource>().Play();
    }
    public void ClickMercedes()
    {
        MercedesSound.GetComponent<AudioSource>().Play();
    }
    public void ClickHonda2()
    {
        Honda2Sound.GetComponent<AudioSource>().Play();
    }
    public void ClickBugatti()
    {
        BugattiSound.GetComponent<AudioSource>().Play();
    }
    public void Update()
    {
        if (UpgradeLevel == 0)
        {
            Car1.SetActive(false);
            Car2.SetActive(false);
            Car3.SetActive(false);
            Car4.SetActive(false);
            Car5.SetActive(false);
            Car6.SetActive(false);
            Car7.SetActive(false);
        }
        if (UpgradeLevel >= 1)
        {
            Car1.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($150000)";
            isFirstBought = true;
        }
        if (UpgradeLevel >= 2)
        {
            Car2.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($200000)";
            isSecondBought = true;
        }
        if (UpgradeLevel >= 3)
        {
            Car3.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($350000)";
            isThirdBought = true;
        }
        if (UpgradeLevel >= 4)
        {
            Car4.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($500000)";
            isFourthBought = true;
        }
        if (UpgradeLevel >= 5)
        {
            Car5.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($700000)";
            isFifthBought = true;
        }
        if (UpgradeLevel >= 6)
        {
            Car6.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($800000)";
            isSixthBought = true;
        }
        if (UpgradeLevel >= 7)
        {
            Car7.SetActive(true);
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isSeventhBought = true;
        }

    }

    public void Car()
    {
        if (GlobalCash.CashCount >= 800000 && isSixthBought == true && isSeventhBought == false)
        {
            GlobalCash.CashCount -= 800000;
            InternalUpgrade = 1450000;
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isSeventhBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 7;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 700000 && isFifthBought == true && isSixthBought == false)
        {
            GlobalCash.CashCount -= 700000;
            InternalUpgrade = 800000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isSixthBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 6;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 500000 && isFourthBought == true && isFifthBought == false)
        {
            GlobalCash.CashCount -= 500000;
            InternalUpgrade = 700000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isFifthBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 5;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 350000 && isThirdBought == true && isFourthBought == false)
        {
            GlobalCash.CashCount -= 350000;
            InternalUpgrade = 500000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isFourthBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 4;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 200000 && isSecondBought == true && isThirdBought == false)
        {
            GlobalCash.CashCount -= 200000;
            InternalUpgrade = 350000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isThirdBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 3;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 150000 && isFirstBought == true && isSecondBought == false)
        {
            GlobalCash.CashCount -= 150000;
            InternalUpgrade = 200000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isSecondBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 2;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }

        if (GlobalCash.CashCount >= 100000 && isFirstBought == false)
        {
            GlobalCash.CashCount -= 100000;
            InternalUpgrade = 150000;
            UpgradeDisplay.GetComponent<Text>().text = "Better car ($" + InternalUpgrade + ")";
            isFirstBought = true;
            LevelBar.Level += 1;
            UpgradeLevel = 1;
            UpgradeSound.GetComponent<AudioSource>().Play();
        }
    }
}
