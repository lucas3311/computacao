using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroyParticle : MonoBehaviour {
    public GameObject particle;
	// Use this for initialization
	void Start () {
        particle.GetComponent<DestroyParticle>().Destroy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
