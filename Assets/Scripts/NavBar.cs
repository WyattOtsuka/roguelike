using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NavBar : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    void Start()
    {
        GridLayoutGroup glg = GetComponent<GridLayoutGroup>();
        float width = this.GetComponent<RectTransform>().rect.width;
        float spacing = (width-75)/5;
        glg.cellSize = new Vector2(spacing,100);
    }
}
