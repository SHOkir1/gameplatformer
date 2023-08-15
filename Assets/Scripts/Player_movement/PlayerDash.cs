using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerDash : MonoBehaviour
{
    //TODO:
    //arrow points at mouse
    //click teleports player in direction of mouse
    //velocity does not change
    //teleport stops before destination if wall is detected
    private Vector2 cursorPosition;
    private float cursorDirection;
    public int dashDistance;
    public GameObject indicator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerx = gameObject.transform.position.x;
        float playery = gameObject.transform.position.y;
        cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float cursorx = cursorPosition.x;
        float cursory = cursorPosition.y;
        cursorDirection = Mathf.Atan2(cursory - playery, cursorx - playerx);
        if (Input.GetMouseButtonDown(0))
            dash(cursorDirection);
        indicator.transform.SetPositionAndRotation(new Vector3(Mathf.Cos(cursorDirection) * 1 + transform.position.x, Mathf.Sin(cursorDirection) * 1 + transform.position.y), transform.rotation);

        //debug
        Vector2 destination = new Vector2(Mathf.Cos(cursorDirection) * dashDistance + transform.position.x, Mathf.Sin(cursorDirection) * dashDistance + transform.position.y);
        Debug.DrawLine(transform.position, destination, Color.blue);
    }
    void dash(float angle) {
        
        Vector2 destination = new Vector2(Mathf.Cos(angle)*dashDistance+transform.position.x, Mathf.Sin(angle)*dashDistance+transform.position.y);
        transform.SetPositionAndRotation(destination, transform.rotation);
    }
}
