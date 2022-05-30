using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card1 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
    System.Random rnd = new System.Random();
    public TextMeshProUGUI text;
    public int value;

    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    [SerializeField] private ScrollRect scrollRect;

    private bool? Scrolling = null;

    private void Awake() {
        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        scrollRect = GameObject.FindGameObjectWithTag("CardDeckView").GetComponent<ScrollRect>();
    }

    void Start()
    {
        value = rnd.Next(3,10);
        text.text = value.ToString();
    }

    public void OnBeginDrag(PointerEventData eventData){
        ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.beginDragHandler);
        if (eventData.delta.x > eventData.delta.y) {
            Scrolling = true;
        } else {
            canvasGroup.alpha = 0.6f;
            canvasGroup.blocksRaycasts = false;
            eventData.pointerDrag.transform.SetParent(canvas.transform, true);
        }
    }

    public void OnDrag(PointerEventData eventData){
        if (Scrolling == true) {
            ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.dragHandler);
        } else {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData){
        canvasGroup.alpha = 1;
        if (this.transform.parent.GetComponent<EnemyArea>() == null) {
            canvasGroup.blocksRaycasts = true;
        }
        ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.endDragHandler);
        Scrolling = null;
    }

    public void OnPointerDown(PointerEventData eventData){
    }
}
