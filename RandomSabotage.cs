using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSabotage : MonoBehaviour
{
    public GameObject ImageBarrel;
    public GameObject Pirate;
    public GameObject PirateDisplay;
    public bool CanRaid = true;
    public float RaidSize;
    public float RaidSizeFloored = 10.0f;
    public float RandomTime;
    public static float MaxRaidSize = 30.0f;
    public static float RaidIndex;

    public void Start()
    {
        Pirate.SetActive(false);
    }
    public void Update()
    {
        if (RaidSizeFloored >= GlobalBarrel.BarrelCount && CanRaid == true)
        {
            CanRaid = false;
            RaidSizeFloored = GlobalBarrel.BarrelCount;
            GlobalBarrel.BarrelCount -= RaidSizeFloored;
            ImageBarrel.GetComponent<Animation>().Play("BarrelStealAnim");
            Pirate.GetComponent<Animation>().Play("PirateAnim");
            PirateDisplay.GetComponent<Text>().text = "-" + RaidSizeFloored;
            StartCoroutine(Raid());
        }
        if (RaidSizeFloored <= GlobalBarrel.BarrelCount && CanRaid == true)
        {
            CanRaid = false;
            GlobalBarrel.BarrelCount -= RaidSizeFloored;
            ImageBarrel.GetComponent<Animation>().Play("BarrelStealAnim");
            Pirate.GetComponent<Animation>().Play("PirateAnim");
            PirateDisplay.GetComponent<Text>().text = "-" + RaidSizeFloored;
            StartCoroutine(Raid());
        }
        IEnumerator Raid()
        {
            MaxRaidSize = ((50.0f * LevelBar.Level) / RaidIndex);
            RaidSize = Random.Range(0.0f, MaxRaidSize);
            RandomTime = Random.Range(10.0f, 25.0f);
            RaidSizeFloored = Mathf.Floor(RaidSize);
            yield return new WaitForSeconds(RandomTime);
            Pirate.SetActive(true);
            CanRaid = true;
        }
    }
}