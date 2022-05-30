using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject CardDeck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick() 
    {
        int max = 15 - CardDeck.transform.childCount;
        for (var i = 0; i < max; i++){
            GameObject PlayerCard = Instantiate(Card1, new Vector3(0,0,0), Quaternion.identity);
            PlayerCard.transform.SetParent(CardDeck.transform, false);
            TextMeshPro child = PlayerCard.GetComponent<TextMeshPro>();
        }        
    }
}
