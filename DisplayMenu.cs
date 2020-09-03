using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject ShopPanel;
    public GameObject HomePanel;
    public GameObject CloseButton;

    public void ClickTheButton()
    {
        MenuPanel.SetActive(true);
        ShopPanel.SetActive(false);
        HomePanel.SetActive(false);
        CloseButton.SetActive(true);
    }
    public void ClickTheButtonClose()
    {
        MenuPanel.SetActive(false);
        CloseButton.SetActive(false);
    }
}
