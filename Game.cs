using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float Ccount;
    public float Bcount;
    public float GameLevel;
    public float XP;
    public int Dcount;
    public float SpeedLevel;
    public int ClickLevel;
    public int PumpLevel;
    public int CarLevel;
    public int FenceLevel;
    public int Location; 
    

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadGame()
    {
        GameData data = SaveSystem.LoadGame();

        GlobalCash.CashCount = data.Ccount;
        GlobalBarrel.BarrelCount = data.Bcount;
        GlobalDiamonds.DiamondCount = data.Dcount;
        MainButtonClick.ClickUpgradeLevel = data.ClickLevel;
        SpeedUpgrade.SpeedUpgradeLevel = data.SpeedLevel;
        PurchaseLog.UpgradeLevel = data.PumpLevel;
        SportsCar.UpgradeLevel = data.CarLevel;
        LevelBar.BarValue = data.XP;
        LevelBar.Level = data.GameLevel;
        FenceUpgrade.FenceUpgradeLevel = data.FenceLevel;
        LocationManager.Location = data.Location;
    }
    public void Start()
    {
        InvokeRepeating("SaveGame", 2.0f, 2.0f);
        LoadGame();
    }
    // ERASE DATA
    public void EraseData()
    {
        LocationManager.Location = 0;
        FenceUpgrade.FenceUpgradeLevel = 0;
        LevelBar.Level = 1;
        LevelBar.BarValue = 0;
        SportsCar.UpgradeLevel = 0;
        PurchaseLog.UpgradeLevel = 0;
        SpeedUpgrade.SpeedUpgradeLevel = 0;
        MainButtonClick.ClickUpgradeLevel = 0;
        GlobalBarrel.BarrelCount = 0;
        GlobalCash.CashCount = 0;
        //GetComponent<PurchaseLog>().isFirstBought = false;
        //GetComponent<PurchaseLog>().isSecondBought = false;
        //GetComponent<PurchaseLog>().isThirdBought = false;
        //GetComponent<PurchaseLog>().isFourthBought = false;
        //GetComponent<PurchaseLog>().isFifthBought = false;
        //GetComponent<PurchaseLog>().isSixthBought = false;
    }
}
