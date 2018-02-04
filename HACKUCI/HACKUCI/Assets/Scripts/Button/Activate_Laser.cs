using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Laser : MonoBehaviour {
    public GameObject laser;
    public GameObject sprite1;
    public Sprite openMouth;
    public Sprite closedMouth;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {

        laser.SetActive(true);
        sprite1.GetComponent<SpriteRenderer>().sprite = openMouth;
        //laser.GetComponent<Renderer>().material.color = new Color(laser.GetComponent<Renderer>().material.color.r, laser.GetComponent<Renderer>().material.color.g, laser.GetComponent<Renderer>().material.color.b, 1);

    }

    void OnMouseUp()
    {

        laser.SetActive(false);
        sprite1.GetComponent<SpriteRenderer>().sprite = closedMouth;
        //laser.GetComponent<Renderer>().material.color = new Color(laser.GetComponent<Renderer>().material.color.r, laser.GetComponent<Renderer>().material.color.g, laser.GetComponent<Renderer>().material.color.b, 0);

    }

}
