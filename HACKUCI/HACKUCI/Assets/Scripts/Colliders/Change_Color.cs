using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color : MonoBehaviour {

    public float r;
    public float g;
    public float b;
    public GameObject laser;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "button")
        {

            laser.GetComponent<Renderer>().material.color = new Color(r,g,b);

        }

    }
}
