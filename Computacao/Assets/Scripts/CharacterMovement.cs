﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    /// <summary>
    /// 1 - The speed of the ship
    /// </summary>
    public Vector2 speed = new Vector2(5f, 2f);

    //The position you clicked
    public Vector2 targetPosition;
    //That position relative to the players current position (what direction and how far did you click?)
    public Vector2 relativePosition;

    // 2 - Store the movement
    private Vector2 movement;

    public bool isOnDialogue = false; 

    void Update()
    {
        // 3 - Retrieve the mouse position
        if (Input.GetKeyDown(KeyCode.Mouse0) && isOnDialogue == false)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        //4 - Find the relative poistion of the target based upon the current position
        // Update each frame to account for any movement
        relativePosition = new Vector2(
            targetPosition.x - gameObject.transform.position.x,
            targetPosition.y - gameObject.transform.position.y);
    }

    void FixedUpdate()
    {
        // 5 - If you are about to overshoot the target, reduce velocity to that distance
        //      Else cap the Movement by a maximum speed per direction (x then y)
        if (speed.x * Time.deltaTime >= Mathf.Abs(relativePosition.x))
        {
            movement.x = relativePosition.x;
        }
        else
        {
            movement.x = speed.x * Mathf.Sign(relativePosition.x);
        }
        if (speed.y * Time.deltaTime >= Mathf.Abs(relativePosition.y))
        {
            movement.y = relativePosition.y;
        }
        else
        {
            movement.y = speed.y * Mathf.Sign(relativePosition.y);
        }

        // 6 - Move the game object using the physics engine
        gameObject.GetComponent<Rigidbody2D>().velocity = movement;

    }
}
