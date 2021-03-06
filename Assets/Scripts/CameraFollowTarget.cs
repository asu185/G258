﻿using UnityEngine;
using System.Collections;

public class CameraFollowTarget : MonoBehaviour {

	/**
	 * Follows the assigned target
	 */

	public Transform target = null;
	public float smoothTime = 0.2f;
	public float xOffset, yOffset; 

	// Use this for initialization
	void Awake () {
		if(target == null){
			Debug.Log ("Give camera a target");

		}

	}

	/**
	 * Follows from the objects current position to the targets position 
	 */
	void FixedUpdate () {
		Vector3 temp = target.position;
		temp.x += xOffset;
		temp.y += yOffset;
		temp.z = transform.position.z;

		transform.position = Vector3.Lerp(transform.position, temp, smoothTime);

	}
}
