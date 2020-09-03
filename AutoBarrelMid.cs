
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Third Pump $40000, 4/s

public class AutoBarrelMid : MonoBehaviour
{
    public bool MiningOil = false;
    public static float OilIncrease = 1;
    public float InternalIncrease;
    public float GlobalSpeedIndex = 1;

    void Update()
    {
        InternalIncrease = OilIncrease;
        if (MiningOil == false)
        {
            MiningOil = true;
            StartCoroutine(MineTheOil());
        }
    }

    IEnumerator MineTheOil()
    {
        GlobalSpeedIndex = SpeedUpgrade.SpeedIndex;
        GlobalBarrel.BarrelCount += InternalIncrease * 10;
        yield return new WaitForSeconds(GlobalSpeedIndex);
        MiningOil = false;
    }
}
