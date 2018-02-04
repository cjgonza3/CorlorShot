using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressed_Movement : MonoBehaviour {

    public Vector3 screenPoint, offset;
    private bool isDragged = false;
    public GameObject edgeUp, edgeDown;
    // Use this for initialization
    void Start()
    {
    }
    void OnMouseDown()
    {

        isDragged = true;

    }

    private void OnMouseUp()
    {

        isDragged = false;

    }
    // Update is called once per frame
    void FixedUpdate()
    {
            if (isDragged)
            {
                this.transform.position = new Vector3(this.transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, this.transform.position.z);
            }
    }

}
