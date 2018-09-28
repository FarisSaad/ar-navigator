using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAPoint : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start ()
    {
        GameObject.Instantiate(prefab, gameObject.transform.position + Vector3.left * 3, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
