using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Color : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
