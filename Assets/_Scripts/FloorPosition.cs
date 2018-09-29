using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPosition : MonoBehaviour {

    public Transform target;
    private Transform floor;

	
	// Update is called once per frame
	void Update ()
    {
        floor = target.Find("Target(Clone)");
        if (floor != null)
        {
            transform.position = new Vector3(transform.position.x, floor.position.y - 1, transform.position.z);
        }
    }
}
