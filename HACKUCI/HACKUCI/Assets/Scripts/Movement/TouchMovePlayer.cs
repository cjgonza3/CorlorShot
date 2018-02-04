using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovePlayer : MonoBehaviour
{
    public GameObject laser;

    private bool moveAllowed = true;
    private float deltaX, deltaY;
    private float laserX, laserY;
    private Rigidbody2D rb;

    public GameObject UpperBound, LowerBound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        deltaX = transform.position.x;
        laserX = laser.transform.position.x;
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
                        if (touch.position.x < (Screen.width) / 4)
                        {
                            deltaY = touchPos.y - transform.position.y;
                            moveAllowed = true;
                        }

                        break;
                    case TouchPhase.Moved:
                        if (touch.position.x < (Screen.width) / 4
                            && deltaY <= UpperBound.transform.position.y
                            && deltaY >= LowerBound.transform.position.y
                            )
                        {
                            rb.MovePosition(new Vector2(deltaX, touchPos.y - deltaY));
                            //laser.MovePosition(new Vector2(laserX, touchPos.y - laserY));
                        }
                        break;
                    case TouchPhase.Ended:
                        break;
                }
            }

        }
    }

}
