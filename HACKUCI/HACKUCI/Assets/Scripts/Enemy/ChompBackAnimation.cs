using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChompBackAnimation : MonoBehaviour {

 public Sprite openMouth;
    public Sprite closeMouth;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
	// Use this for initialization
	void Start () {
		//grab color
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            if (this.GetComponent<SpriteRenderer>().sprite == openMouth)
            {
                this.GetComponent<SpriteRenderer>().sprite = closeMouth;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = openMouth;
            }
           

        }
	}
}
