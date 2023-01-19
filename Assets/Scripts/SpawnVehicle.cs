using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour
{
    public GameObject truck;
    public GameObject tank;
    public bool left;
    public int time=8;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnvehicle", time, time);
    }

    // Update is called once per frame
    void Update()
    {

        

     
    }

    void spawnvehicle()
    {
        int randumno = Random.Range(1, 10);

        if (randumno % 2 == 0)
        {
         

           if(left==true)
           {
                Instantiate(truck, this.transform.position, Quaternion.Euler(0,180,0));
           }
           else
            {
                Instantiate(truck, this.transform.position, Quaternion.Euler(0,0,0));
            }
          

        }
        else
        {
            if (left == false)
            {
                Instantiate(tank, this.transform.position, Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Instantiate(tank, this.transform.position, Quaternion.Euler(0, 0, 0));
            }


        }

    }

}
