using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertDiamonds : MonoBehaviour
{
    public GameObject ConvertSound;
    public void ClickDiamondsConvert()
    {
        if (GlobalDiamonds.DiamondCount > 0)
        {
            GlobalCash.CashCount += (3000.0f * GlobalDiamonds.DiamondCount * LevelBar.Level);
            ConvertSound.GetComponent<AudioSource>().Play();
            GlobalDiamonds.DiamondCount = 0;
        }
    }
    public void ClickDiamondConvert()
    {
        if (GlobalDiamonds.DiamondCount > 0)
        {
            GlobalCash.CashCount += 3000.0f * LevelBar.Level;
            ConvertSound.GetComponent<AudioSource>().Play();
            GlobalDiamonds.DiamondCount -= 1;
        }
    }
}
