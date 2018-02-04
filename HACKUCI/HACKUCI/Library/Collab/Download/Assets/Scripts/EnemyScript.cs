using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;
    private float directionChangeTime;
    private float latestDirectionChangeTime;
    private float speed;

    private Vector2 movementDirection;
    private Vector2 movementPerSecond;
    private Vector2 TopScreenBound;
    private Vector2 BottomScreenBound;

    Color[] colors;



	void Start ()
    {
        colors = new Color[] {Color.red, Color.yellow, Color.green, Color.blue, Color.magenta};
        int randColor = Random.Range(0, 5);
        this.GetComponent<Renderer>().material.color = colors[randColor];
        latestDirectionChangeTime = 0f;
        speed = Random.Range(1f, 3f);
        TopScreenBound = Camera.main.ViewportToWorldPoint(new Vector2(0f, .95f));
        BottomScreenBound = Camera.main.ViewportToWorldPoint(new Vector2(0f, .05f));
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.95f, 1f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        CalculateNewMovementVector();
    }
	
    void CalculateNewMovementVector ()
    {
        movementDirection = new Vector2(Random.Range(-1.0f, -.25f), Random.Range(-.7f, .7f)).normalized;
        movementPerSecond = movementDirection * speed;
        directionChangeTime = Random.Range(3f, 6f);
    }
	void Update ()
    {
        if (Time.time-latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            CalculateNewMovementVector();
        }
        if (gameObject.transform.position.y >= TopScreenBound.y)
        {
            movementDirection.y *= -1;
            movementPerSecond = movementDirection * speed;
        }
        else if (gameObject.transform.position.y <= BottomScreenBound.y)
        {
            //gameObject.transform.position.y = BottomScreenBound.y;
            movementDirection.y *= -1;
            movementPerSecond = movementDirection * speed;
        }
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y + (movementPerSecond.y * Time.deltaTime));   
            /*
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, -.05f, 1f);
        pos.y = Mathf.Clamp(pos.y, 0.05f, 0.95f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        */
    }

}
