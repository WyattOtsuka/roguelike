using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NavBar : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public GameObject MapPanel;
    public GameObject InventoryPanel;
    public GameObject SettingsPanel;

    void Start()
    {
        GridLayoutGroup glg = GetComponent<GridLayoutGroup>();
        float width = this.GetComponent<RectTransform>().rect.width;
        float spacing = (width-75)/5;
        glg.cellSize = new Vector2(spacing,100);
    }
    public void OnMapClick() {
        MapPanel.SetActive(!MapPanel.activeSelf);
        InventoryPanel.SetActive(false);
        SettingsPanel.SetActive(false);

    }
    public void OnInventoryClick() {
        InventoryPanel.SetActive(!InventoryPanel.activeSelf);
        MapPanel.SetActive(false);
        SettingsPanel.SetActive(false);

    }
    public void OnStatsClick() {

    }
    public void OnSettingsClick () {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
        MapPanel.SetActive(false);
        InventoryPanel.SetActive(false);
    }
}
