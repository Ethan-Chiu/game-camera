using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

    public Vector3 dis;
    public Transform player;
	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = player.position + dis;
	}
}
