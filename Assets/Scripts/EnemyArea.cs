using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyArea : MonoBehaviour, IDropHandler
{
    public Enemy enemy1;
    public Canvas canvas;
    

    public void OnDrop(PointerEventData eventData) {
        // Deal Damage
        Card1 card = eventData.pointerDrag.GetComponent<Card1>();
        card.transform.SetParent(this.transform, false);
        enemy1.UpdateHealth(-card.value);

        //Take Damage
        canvas.GetComponent<GameHandler>().takeDamge(5);
    
    }
}
