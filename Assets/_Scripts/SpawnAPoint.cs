using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAPoint : MonoBehaviour {

    public GameObject prefab;
    Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        GameObject.Instantiate(prefab, offset, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
