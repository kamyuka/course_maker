
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{


    public GameObject Parts1;
    public GameObject Parts2;
    public GameObject Parts3;
    public GameObject Ball;

    int update_count;
    int put_count;
    int stop_coumt;
    int restart = 0;

    void Update()
    {


        int put1 = Parts1.GetComponent<Put>().putJudge;
        int put2 = Parts2.GetComponent<Put>().putJudge;
        int put3 = Parts3.GetComponent<Put>().putJudge;


        if (put1 != 0 && put2 != 0 && put3 != 0)
        {
            put_count += 1;
        }
        else
        {
            put_count = 0;
        }

        if (put_count > 10)
        {
            Rigidbody r = Ball.GetComponent<Rigidbody>();
            r.isKinematic = false;
            put_count = 0;
            restart = 1;
        }

        if (restart == 1 && Input.GetMouseButtonDown(0))
        {
            restart = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



    }



}

