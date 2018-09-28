using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToPlayerY : MonoBehaviour {

    private Transform player;

    // Use this for initialization
    void Start()
    {
        player = Camera.main.transform;
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
