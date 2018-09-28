using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRenderer : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // get all renderers in this object and its children:
        Renderer[] renders = GetComponentsInChildren<Renderer>();

        foreach (var item in renders)
        {
            item.material.renderQueue = 2002; // set their renderQueue
        }
    }
}
