using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    public GameObject DisplayLevel;
    public GameObject LevelUpSound;
    public static float Level = 1f;
    public static float BarValue;
    public float BarLeft = 1f;
    public float PlusValue;

    void Update()
    {
        
        if (BarValue >= BarLeft)
        {
            PlusValue = BarValue - BarLeft;
        }
        if (BarValue >= 1f)
        {
            BarValue = 0f + PlusValue;
            Level += 1f;
            GlobalCash.CashCount += 500.0f * Level;
            LevelUpSound.GetComponent<AudioSource>().PlayDelayed(0.2f);
        }

        Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3(BarValue, 1f, 1f);

        DisplayLevel.GetComponent<Text>().text = "Level " + Level;
    }

}
