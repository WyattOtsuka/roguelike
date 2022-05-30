using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    RectTransform rt;
    void Awake() {
        rt = this.GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.transform.childCount * 110);
    }
}
