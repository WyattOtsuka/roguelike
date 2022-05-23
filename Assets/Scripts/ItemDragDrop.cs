using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragDrop : MonoBehaviour, IPointerDownHandler, IDropHandler
{
    public void OnPointerDown(PointerEventData eventData){
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log("On Drop");
        if(eventData.pointerDrag != null) {
            eventData.pointerDrag.transform.position = this.transform.position;
        }
    }
}
