using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyArea : MonoBehaviour, IDropHandler
{
    public Enemy enemy1;
    public Canvas canvas;
    
    private GameHandler handler;

    public void Awake() {
        handler = canvas.GetComponent<GameHandler>();
    }

    public void OnDrop(PointerEventData eventData) {
        // Deal Damage
        Card1 card = eventData.pointerDrag.GetComponent<Card1>();
        card.transform.SetParent(this.transform, false);
        enemy1.UpdateHealth(-card.value);

        // Check if enemy has died
        if (enemy1.health > 0 ) {
            //Take Damage
            handler.takeDamge(5);
        } else {
            enemy1.health = 25;
            enemy1.text.text = enemy1.health.ToString();
            handler.addExp(75);
        }
    }
}
