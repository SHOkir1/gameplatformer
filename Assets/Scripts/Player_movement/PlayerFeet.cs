using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    public PlayerMovement parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player is touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            parent.isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the player falls off ground without jumping
        if (collision.gameObject.CompareTag("Ground"))
        {
            parent.isGrounded = false;
        }
    }
}
