using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStraight : MonoBehaviour {
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

    public void GameOver(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    void Start()
    {
        Color orange = new Color(1f, .6f, 0f);
        Color yellow = new Color(1f, .922f, .016f);
        colors = new Color[] { Color.red, orange, yellow, Color.green, Color.blue, Color.magenta };
        int randColor = Random.Range(0, 6);
        this.GetComponent<Renderer>().material.color = colors[randColor];
        speed = 5f;
        TopScreenBound = Camera.main.ViewportToWorldPoint(new Vector2(0f, .95f));
        BottomScreenBound = Camera.main.ViewportToWorldPoint(new Vector2(0f, .05f));
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        //pos.x = Mathf.Clamp(pos.x, 0.95f, 3f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        
    }

    void Update()
    {
        if (gameObject.transform.position.y >= TopScreenBound.y)
        {
            transform.position = new Vector2(transform.position.x + (-1 * speed * Time.deltaTime), transform.position.y-.1f);
        }
        else if (gameObject.transform.position.y <= BottomScreenBound.y)
        {
            transform.position = new Vector2(transform.position.x + (-1 * speed * Time.deltaTime), transform.position.y+.1f);
        }
        else
        {
            transform.position = new Vector2(transform.position.x + (-1 * speed * Time.deltaTime), transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall" || collision.gameObject.name == "MainCharacter")
        {
            //Destroy(GameObject.Find("MonsterSpawner"));
            //GameObject.Find("GameElements").SetActive(false);
            GameOver(2);
        }
    }
}
