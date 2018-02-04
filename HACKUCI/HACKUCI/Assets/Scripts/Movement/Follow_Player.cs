using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        this.transform.position = new Vector3(player.transform.position.x+6.4f, player.transform.position.y-0.2f, this.transform.position.z);

    }
}
