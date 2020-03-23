﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateFollow : MonoBehaviour {

    public float speedX = 2.0f;
    public float speedY = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
	// Update is called once per frame
	void Update () {
        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
	}
}
