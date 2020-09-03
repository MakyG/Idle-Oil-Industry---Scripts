using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellBarrel : MonoBehaviour
{
    public GameObject textBox;
    public GameObject BarrelDisplay;
    public GameObject CashFallAnim;
    public GameObject BarrelValueDisplay;

    public static float ValueCoefficient = 1.0f;

    public void ClickTheButton ()
    {
        if (GlobalBarrel.BarrelCount > 0)
        {
            GlobalCash.CashCount += 60.0f * GlobalBarrel.BarrelCount * ValueCoefficient;
            LevelBar.BarValue += (GlobalBarrel.BarrelCount / 100) / (LevelBar.Level / 1.5f);
            GlobalBarrel.BarrelCount -= GlobalBarrel.BarrelCount;
            CashFallAnim.GetComponent<Animation>().Play("CashFallAnim");
        }
    }
    public void Update()
    {
        BarrelValueDisplay.GetComponent<Text>().text = "Barrel value: $" + (ValueCoefficient * 60);
    }
}
