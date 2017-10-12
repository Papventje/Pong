using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnBounce : MonoBehaviour {

    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            source.Play();
        }
    }
}
