using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenRain : MonoBehaviour
{
    public GameObject GoldenCloudInst;
    public GameObject GoldenRainVisual;
    public GameObject GoldenRainAnim;
    public GameObject GoldenRainAnim2;
    public static float GoldIndex = 1;
    public static bool Raining = false;
    public bool CanRain = false;

    public void GoldClick()
    {
        if (!Raining)
        {
            CanRain = false;
            Raining = true;
            StartCoroutine(Rain());
        }

    }
    IEnumerator Rain()
    {
        yield return new WaitForSeconds(3f);
        CanRain = true;
        Raining = false;
    }
    public void Update()
    {
        if (Raining == true)
        {
            GoldIndex = 3f;
            GoldenRainAnim.SetActive(true);
            GoldenCloudInst.GetComponent<Animation>().Play("CloudHideAnim");
            GoldenRainVisual.GetComponent<Animation>().Play("RainAnim");
            GoldenRainAnim.GetComponent<Animation>().Play("GoldTextAnim");
            GoldenRainAnim2.GetComponent<Animation>().Play("PanelAnim");
        }
        if (Raining == false)
        {
            GoldIndex = 1f;
            GoldenRainAnim.SetActive(false);
        }
    }
}
