using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdController : MonoBehaviour
{
    public GameObject AdButton;
    public GameObject MechanicsObject;
    public static AdController instance;

    private string store_id = "3287365";

    private string rewarded_video_ad = "rewardedVideo";

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        Monetization.Initialize(store_id, false);
    }

    public void PlayRewardedAd()
    {
         if (Monetization.IsReady("rewardedVideo"))
         {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(rewarded_video_ad) as ShowAdPlacementContent;

            GlobalDiamonds.DiamondCount += 3;

            if (ad != null)
            {
                ad.Show();
            }
         }
    }
}
