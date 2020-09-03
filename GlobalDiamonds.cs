using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDiamonds : MonoBehaviour
{
    public static int DiamondCount = 0;
    public GameObject DiamondDisplay;
    public GameObject DiamondValueDisplay;
    public int InternalDiamond;

    void Update()
    {
        InternalDiamond = DiamondCount;
        DiamondDisplay.GetComponent<Text>().text = "" + InternalDiamond;
        DiamondValueDisplay.GetComponent<Text>().text = "Diamond value: $" + 3000 * LevelBar.Level;
    }
}
