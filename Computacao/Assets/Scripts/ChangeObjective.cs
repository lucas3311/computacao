using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeObjective : MonoBehaviour {
    public Text Objective;
    int phase = 0;
    public string NewObjectText;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider == gameObject.GetComponent<Collider2D>())
            {
                //Debug.Log(hit.collider.gameObject.name);
                //hit.collider.attachedRigidbody.AddForce(Vector2.up);
                phase = 1;
                Destroy(gameObject.GetComponent<ChangeObjective>(), 2);

            }
            if (phase == 1)
            {
                Objective.text = NewObjectText;
            }
        }
    }
}
