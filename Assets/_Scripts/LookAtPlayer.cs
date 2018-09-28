using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start ()
    {
        player = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(player);
	}
}
