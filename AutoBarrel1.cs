
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBarrel1 : MonoBehaviour
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
        GlobalBarrel.BarrelCount += InternalIncrease * 5;
        yield return new WaitForSeconds(GlobalSpeedIndex);
        MiningOil = false;
    }
}
