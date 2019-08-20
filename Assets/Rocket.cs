using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rbd;
    public int SPEED = 10000;
	// Use this for initialization
	void Start () {
        rbd = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Jump") != 0)
        {
            rbd.AddForce(new Vector3(0, Input.GetAxis("Jump") * Time.deltaTime*SPEED, 0));
        }
	}
}
