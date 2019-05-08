
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class SpinBottle : MonoBehaviour
{

    public bool canRotate;
    public GameObject bottle;
    public float rotation = 0;
    public int inc = 0;
    public int speed = 5;
    public int maxRot = 1440;
    public int minRot = 1080;


    public void Start()
    {

    }

    // Update is called once per frame
    // random number keep updating by one until random number is hit
    public void Update()
    {
        if (canRotate == true){
            if (rotation < inc){

                bottle.transform.Rotate(0, speed * Time.deltaTime, 0);
                //bottle.transform.Rotate(Vector3.one * Time.deltaTime, 0, 0);
                //Debug.Log(canRotate);
                rotation += speed * Time.deltaTime;
            } else if (rotation > inc){
               canRotate = false;
               rotation = 0;
               inc = 0;
        }

        }
    }




    public void StartRotate()
    {
        canRotate = true;
        inc = Random.Range(minRot, maxRot);

    }



}

