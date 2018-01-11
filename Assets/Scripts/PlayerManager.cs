﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Invoke ("Intro", 10f);
	}

	// Update is called once per frame
	void Update () {

	}

	void Intro () {
	}

	private void OnTriggerEnter (Collider other) {
		if (other.tag == "Ladder Training Area" && GameManager.IsInLadderTrainingArea) {
			GameManager.SetInLadderTraining(true);
			
		} else {

		}


		if(other.tag == "Ladder Training Goal"){
			// Ladder trainign manager -> complete steps
			

			// teleport
		}
	}


	public void Teleport(Vector3 to){
		// make blink effect here
		this.transform.position = to;
	}

}