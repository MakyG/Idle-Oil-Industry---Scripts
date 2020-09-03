using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayShop : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject MenuPanel;
    public GameObject HomePanel;
    public GameObject CloseButton;

    public void ClickTheButton()
    {
        ShopPanel.SetActive(true);
        MenuPanel.SetActive(false);
        HomePanel.SetActive(false);
        CloseButton.SetActive(true);
    }
    public void ClickTheButtonClose()
    {
        ShopPanel.SetActive(false);
        CloseButton.SetActive(false);
    }
}
