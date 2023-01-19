using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject BoomEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Vehicle"))
        {
            Instantiate(BoomEffect, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("DeadzoneBomb"))
        {
           // Instantiate(BoomEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
