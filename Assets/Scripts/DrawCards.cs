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
        for (var i = 0; i < 5; i++){
            GameObject PlayerCard = Instantiate(Card1, new Vector3(0,0,0), Quaternion.identity);
            PlayerCard.transform.SetParent(PlayerArea.transform, false);

            TextMeshPro child = PlayerCard.GetComponent<TextMeshPro>();


            //GameObject EnemyCard = Instantiate(Card2, new Vector3(0,0,0), Quaternion.identity);
            //EnemyCard.transform.SetParent(EnemyArea.transform, false);
        }
        
    }
}
