using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyArea : MonoBehaviour, IDropHandler
{
    public Enemy enemy1;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        Card1 card = eventData.pointerDrag.GetComponent<Card1>();
        card.transform.SetParent(this.transform, false);
        enemy1.UpdateHealth(-card.value);
        Debug.Log(enemy1.health.ToString());
    }
}
