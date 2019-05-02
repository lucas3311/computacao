using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text text;
    bool onDialogue = false;
    public int lineNumber = 0;
    // Use this for initialization
    void Start () {

        text.enabled = false;
        
	}
	
	// Update is called once per frame
	void Update () {


	}

    public void lineDialogue(string[] Dialogue)
    {
        onDialogue = true;
        text.enabled = true;

        GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().isOnDialogue = true;
        
        if (Input.GetKey(KeyCode.Mouse0)) {
            lineNumber += 1;
            if (lineNumber == Dialogue.Length)
            {
                text.enabled = false;
                
                onDialogue = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().isOnDialogue = false;
                lineNumber = 0;
            }
        }

        
    }
}
