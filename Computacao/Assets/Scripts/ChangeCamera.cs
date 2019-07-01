using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
    public GameObject cameraOff;
    public GameObject cameraOn;
    public GameObject casaFundo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            cameraOff.SetActive(false);
            cameraOn.SetActive(true);
            casaFundo.SetActive(!casaFundo.activeInHierarchy);
        }
        }
}
