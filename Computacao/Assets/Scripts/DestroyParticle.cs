using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {

	// Use this for initialization
	public void Destroy () {
        gameObject.GetComponent<ParticleSystem>().Stop();
        Destroy(gameObject, 5);
	}

}
