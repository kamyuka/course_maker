using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put : MonoBehaviour {

    public int putJudge;
    int putCount = 0;



    private void OnTriggerStay(Collider collider)
    {
        //float pos = transform.position.z - collider.transform.position.z;


        if (collider.tag == "Parts_enter")
        {
            if (transform.position == collider.transform.position)
            {
                putCount += 1;
            }
            else
            {
                putCount = 0;
            }
        }


        if (collider.tag == "Parts_enter")
        {
            transform.position = collider.transform.position;
        }



        if (putCount > 1)
        {
            putCount = 2;
            putJudge = 1;


            if (collider.name == "PutPoint_cube1")
            {
                GameObject obj = GameObject.Find("PutPoint1");
                Destroy(obj);
            }
            if (collider.name == "PutPoint_cube2")
            {
                GameObject obj = GameObject.Find("PutPoint2");
                Destroy(obj);
            }
        }
    }
}
