using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Game_Manager : MonoBehaviour {
    public Text score_text;
    private int score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score += 1;
        score_text.text = score.ToString();

    }

    public void hello()
    {
        print("hello");
    }

    public void add_points(int points)
    {

        score += points;
        score_text.text = score.ToString();

    }
}
