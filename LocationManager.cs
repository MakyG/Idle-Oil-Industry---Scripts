using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationManager : MonoBehaviour
{
    public GameObject Location0;
    public GameObject Location1;
    public GameObject Location2;
    public GameObject Location3;
    public GameObject UpgradeDisplay;
    public GameObject Clouds;

    public static int Location = 0;
    bool isFirstBought = false;
    bool isSecondBought = false;
    bool isThirdBought = false;
    bool isFourthBought = false;
    public float InternalUpgrade;

    public void BuyNewLocation()
    {
        if (GlobalCash.CashCount >= 560000 && isSecondBought == true && isThirdBought == false)
        {
            Location = 3;
            GlobalCash.CashCount -= 560000;
            //InternalUpgrade = ;
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isThirdBought = true;
        }
        if (GlobalCash.CashCount >= 340000 && isFirstBought == true && isSecondBought == false)
        {
            Location = 2;
            GlobalCash.CashCount -= 340000;
            InternalUpgrade = 560000;
            UpgradeDisplay.GetComponent<Text>().text = "New land (" + InternalUpgrade + ")";
            isSecondBought = true;
        }
        if (GlobalCash.CashCount >= 240000 && isFirstBought == false)
        {
            Location = 1;
            GlobalCash.CashCount -= 240000;
            InternalUpgrade = 340000;
            UpgradeDisplay.GetComponent<Text>().text = "New land (" + InternalUpgrade + ")";
            isFirstBought = true;
        }
    }

    public void Update()
    {
        if (Location == 0)
        {
            SellBarrel.ValueCoefficient = 1f;
            Location0.SetActive(true);
            Location1.SetActive(false);
            Location2.SetActive(false);
            Location3.SetActive(false);
            isFirstBought = false;
            isSecondBought = false;
            isThirdBought = false;
            isFourthBought = false;
            UpgradeDisplay.GetComponent<Text>().text = "New location ($240000)";
        }
        if (Location == 1)
        {
            SellBarrel.ValueCoefficient = 1.3f;
            Location1.SetActive(true);
            Location0.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "New location ($340000)";
            isFirstBought = true;
        }
        if (Location == 2)
        {
            SellBarrel.ValueCoefficient = 1.6f;
            Location2.SetActive(true);
            Location1.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "New location ($560000)";
            isFirstBought = true;
            isSecondBought = true;
        }
        if (Location == 3)
        {
            SellBarrel.ValueCoefficient = 1.9f;
            Location3.SetActive(true); // MARS
            Location2.SetActive(false);
            UpgradeDisplay.GetComponent<Text>().text = "Max level";
            isFirstBought = true;
            isSecondBought = true;
            isThirdBought = true;
            Clouds.SetActive(false);
        }
        else
        {
            Clouds.SetActive(true);
        }
    }
}
