using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerArea : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        Card1 card = eventData.pointerDrag.GetComponent<Card1>();
        card.transform.SetParent(this.transform, false);
    }
}
