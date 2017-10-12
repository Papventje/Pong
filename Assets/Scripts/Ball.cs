using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float ballVelocity = 3000;

    private Rigidbody rb;
    private bool isStarted;
    private int randomInt;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        randomInt = Random.Range(1, 3);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            //speed up ball
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isStarted == false)
        {
            transform.parent = null;
            isStarted = true;
            rb.isKinematic = false;
            if (randomInt == 1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
            }
            if(randomInt == 2)
            {
                rb.AddForce(new Vector3(ballVelocity, -ballVelocity, 0));
            }
        }
    }
}
