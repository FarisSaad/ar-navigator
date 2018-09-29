using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAPoint : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //GameObject.Instantiate(prefab, offset, Quaternion.identity);
        transform.position = offset;

	}
	
}
