﻿using UnityEngine;
using System.Collections;

public class superjump : MonoBehaviour {
	
	void OnTriggerEnter(Collider col){
		Debug.Log (col.name + " entered ");
		if(col.gameObject.name.Equals("Player") || col.gameObject.name.Equals("player")){
			Debug.Log ("jump");
			//Destroy(this.gameObject);
			//CoinController.increaseCoins();
			GameObject.Find("Player").GetComponent<PlayerMovement>().sjump = true;
		}
	}
}