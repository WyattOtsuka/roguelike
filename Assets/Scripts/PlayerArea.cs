using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerArea : MonoBehaviour, IDropHandler
{
    public GameObject CardDeck;
    public void OnDrop(PointerEventData eventData) {
        Card1 card = eventData.pointerDrag.GetComponent<Card1>();
        card.transform.SetParent(CardDeck.transform, false);
    }
}
