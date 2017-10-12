using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float speed = .25f;
    public Vector3 playerPos;

	void Update () {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * speed);
        playerPos = new Vector3(-7, Mathf.Clamp(yPos, -2.32f, 2.32f), 0);
        gameObject.transform.position = playerPos;
	}
}
