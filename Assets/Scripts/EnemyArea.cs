using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyArea : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        eventData.pointerDrag.transform.SetParent(this.transform, false);
    }
}
