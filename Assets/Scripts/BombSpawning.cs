using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawning : MonoBehaviour
{
    public GameObject bomb;
    Vector2 touchPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.y > Screen.height / 2)
            {
              touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            }
          

            if(touch.phase==TouchPhase.Began && touchPos!=null && touch.position.y > Screen.height /2)
            {
                Instantiate(bomb, touchPos, Quaternion.identity);

            }
        }
        
    }
}
