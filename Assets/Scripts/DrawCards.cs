using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick() 
    {
        int max = 5 - PlayerArea.transform.childCount;
        for (var i = 0; i < max; i++){
            GameObject PlayerCard = Instantiate(Card1, new Vector3(0,0,0), Quaternion.identity);
            PlayerCard.transform.SetParent(PlayerArea.transform, false);

            TextMeshPro child = PlayerCard.GetComponent<TextMeshPro>();
        }
        
    }
}
