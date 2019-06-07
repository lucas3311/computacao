using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour {


    public GameObject cursorManager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit.collider == gameObject.GetComponent<Collider2D>())
        {
            cursorManager.GetComponent<CursorManager>().isCursorOn = true;
        }
        else
        {
            cursorManager.GetComponent<CursorManager>().isCursorOn = false;
        }
    }
}
