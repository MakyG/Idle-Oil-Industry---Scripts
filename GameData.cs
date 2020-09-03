using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public float Ccount = GlobalCash.CashCount;
    public float Bcount = GlobalBarrel.BarrelCount;
    public int Dcount = GlobalDiamonds.DiamondCount;
    public int ClickLevel = MainButtonClick.ClickUpgradeLevel;
    public int SpeedLevel = SpeedUpgrade.SpeedUpgradeLevel;
    public int PumpLevel = PurchaseLog.UpgradeLevel;
    public int CarLevel = SportsCar.UpgradeLevel;
    public float XP = LevelBar.BarValue;
    public float GameLevel = LevelBar.Level;
    public int FenceLevel = FenceUpgrade.FenceUpgradeLevel;
    public int Location = LocationManager.Location;

    public GameData(Game game)
    { 
        game.Location = LocationManager.Location;
        game.FenceLevel = FenceUpgrade.FenceUpgradeLevel;
        game.GameLevel = LevelBar.Level;
        game.XP = LevelBar.BarValue;
        game.CarLevel = SportsCar.UpgradeLevel;
        game.PumpLevel = PurchaseLog.UpgradeLevel;
        game.SpeedLevel = SpeedUpgrade.SpeedUpgradeLevel;
        game.ClickLevel = MainButtonClick.ClickUpgradeLevel;
        game.Bcount = GlobalBarrel.BarrelCount;
        game.Dcount = GlobalDiamonds.DiamondCount;
        game.Ccount = GlobalCash.CashCount;
    }
}
