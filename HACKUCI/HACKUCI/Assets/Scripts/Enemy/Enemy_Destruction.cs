using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Enemy_Destruction : MonoBehaviour {
    private Game_Manager script;
    private GameObject manager;
    private GameObject laser;
    private Boolean touching;
    public int points;
    // Use this for initialization
    void Start () {

        touching = false;
        manager = GameObject.FindWithTag("manager");
        script = manager.GetComponent<Game_Manager>();

    }
	
	// Update is called once per frame
	void Update () {

        if (touching)
        {
            laser = GameObject.FindWithTag("laser");
            print(this.GetComponent<Renderer>().material.color);
            print(laser.GetComponent<Renderer>().material.color);
            if (this.GetComponent<Renderer>().material.color == laser.GetComponent<Renderer>().material.color)
            {

                script.add_points(points);
                Destroy(this.gameObject);

            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "laser")
        {

            touching = true;

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "laser")
        {

            touching = false;

        }

    }
}
