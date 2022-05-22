using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NavBar : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public GameObject MapPanel;

    void Start()
    {
        GridLayoutGroup glg = GetComponent<GridLayoutGroup>();
        float width = this.GetComponent<RectTransform>().rect.width;
        float spacing = (width-75)/5;
        glg.cellSize = new Vector2(spacing,100);
    }
    public void OnMapClick() {
        MapPanel.SetActive(!MapPanel.activeSelf);
    }
    public void OnInventoryClick() {

    }
    public void OnStatsClick() {

    }
    public void OnSettingsClick () {

    }
}
