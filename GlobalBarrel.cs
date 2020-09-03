using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBarrel : MonoBehaviour
{
    public static float BarrelCount;
    public GameObject BarrelDisplay;
    public float InternalBarrel;
    public GameObject BarrelVisual1;
    public GameObject BarrelVisual2;

    void Update() {
        InternalBarrel = BarrelCount;
        BarrelDisplay.GetComponent<Text>().text = "" + InternalBarrel;
        if (BarrelCount > 200)
        {
            BarrelVisual1.SetActive(true);
        }
        else
        {
            BarrelVisual1.SetActive(false);
        }
        if (BarrelCount > 500)
        {
            BarrelVisual2.SetActive(true);
        }
        else
        {
            BarrelVisual2.SetActive(false);
        }
    }
}
