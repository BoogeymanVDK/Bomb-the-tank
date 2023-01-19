using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 2f;

    public bool truck;

    float time=0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(1f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (truck == false)
        {
            rb.velocity = transform.right * speed;
        }
        else
        {
            rb.velocity = -transform.right * speed;
        }


        time = time + 1f*Time.deltaTime;

        if(time>3)
        {
            speed = speed + 0.1f* Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Deadzone"))
        {
            Destroy(this.gameObject);
        }
    }

}
