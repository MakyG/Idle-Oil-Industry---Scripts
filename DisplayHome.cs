using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayHome : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject MenuPanel;
    public GameObject HomePanel;
    public GameObject CloseButton;

    public void ClickTheButton()
    {
        HomePanel.SetActive(true);
        ShopPanel.SetActive(false);
        MenuPanel.SetActive(false);
        CloseButton.SetActive(true);
    }
    public void ClickTheButtonClose()
    {
        HomePanel.SetActive(false);
        CloseButton.SetActive(false);
    }
}
