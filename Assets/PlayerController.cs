using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float force = 10.0f;

	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-force, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(force, 0, 0);
        }

    }
}
