using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spining : MonoBehaviour {
    public float speed = 25;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
	}
}
