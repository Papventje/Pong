using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocityOnBounce : MonoBehaviour {

    [SerializeField] private Transform cube;
    private float timesTouched = 0;

    private float AddedVelocity = 300f;

	// Use this for initialization
	void Start () {
        Rigidbody rb = cube.GetComponent<Rigidbody>();
	}

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            timesTouched++;
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(20, 20, 0));
        }
    }
}
