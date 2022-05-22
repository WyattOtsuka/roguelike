using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2 &&
            Input.GetTouch(0).phase == TouchPhase.Moved &&
            Input.GetTouch(1).phase == TouchPhase.Moved) 
        {
            Vector2 curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
            Vector2 prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition)
                - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions

            float touchDelta = curDist.magnitude - prevDist.magnitude;
            float speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;
            float speedTouch1 = Input.GetTouch(1).deltaPosition.magnitude / Input.GetTouch(1).deltaTime;

            Debug.Log(touchDelta);

            this.transform.localScale += touchDelta * new Vector3(0.002f, 0.002f,0);
        }    
    
    }
}
