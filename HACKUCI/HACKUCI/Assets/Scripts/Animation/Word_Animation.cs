using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word_Animation : MonoBehaviour {
    public float nextActionTime = 1f;
    public float period = 9f;
    // Use this for initialization
    void Start()
    {
        //grab color
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {

            if (this.enabled == false)
            {
                this.enabled = true;
                nextActionTime += 1f;
            }
            else
            {
                this.enabled = false;
                nextActionTime += period;
            }


        }
    }
}
