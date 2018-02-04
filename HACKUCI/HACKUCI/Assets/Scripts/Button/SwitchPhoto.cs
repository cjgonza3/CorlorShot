using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPhoto : MonoBehaviour {
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
        sprite1.GetComponent<SpriteRenderer>().sprite = openMouth;

    }
    void OnMouseUp()
    {
        sprite1.GetComponent<SpriteRenderer>().sprite = closedMouth;

    }
}
