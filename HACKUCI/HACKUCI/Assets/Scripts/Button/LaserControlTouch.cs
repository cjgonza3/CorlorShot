using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControlTouch : MonoBehaviour
{
    public GameObject laser;
    public GameObject sprite1;
    public Sprite openMouth;
    public Sprite closedMouth;

    private float deltaX, deltaY;
    private Rigidbody2D rb;

    public GameObject LaserUpperBound, LaserLowerBound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        deltaX = transform.position.x;
    }

    void Update()
    {
        int nbTouches = Input.touchCount;

        if (nbTouches > 0)
        {
            for (int i = 0; i < nbTouches; ++i)
            {
                Touch touch = Input.GetTouch(i);

                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        if (touch.position.x >= Screen.width - (Screen.width / 4))
                        {
                            laser.SetActive(true);
                            sprite1.GetComponent<SpriteRenderer>().sprite = openMouth;
                            rb.MovePosition(new Vector2(deltaX, touchPos.y));
                            //deltaY = touchPos.y - transform.position.y;
                        }

                        break;
                    case TouchPhase.Moved:
                        if (touch.position.x >= Screen.width - (Screen.width / 4)
                            && deltaY <= LaserUpperBound.transform.position.y
                            && deltaY >= LaserLowerBound.transform.position.y
                            )
                        {
                            laser.SetActive(true);
                            sprite1.GetComponent<SpriteRenderer>().sprite = openMouth;
                            rb.MovePosition(new Vector2(deltaX, touchPos.y - deltaY));
                        }
                        break;
                    case TouchPhase.Ended:
                        laser.SetActive(false);
                        sprite1.GetComponent<SpriteRenderer>().sprite = closedMouth;
                        break;
                }
            }

        }
    }

}
