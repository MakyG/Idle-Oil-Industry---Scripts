using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static float CashCount = 0f;
    public GameObject CashDisplay;
    public float InternalCash;

    void Update() {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "" + InternalCash;
    }
}
