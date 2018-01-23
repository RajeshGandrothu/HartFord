using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	 public GameManager gameManager;
	void Awake () {
		Invoke ("Intro", 10f);
	}

	void Update () {

	}

	void Intro () { }

	void OnTriggerEnter (Collider other) {
		Debug.Log(other.tag);
		if (other.tag == "Ladder Training Enter") {
			gameManager.LadderTraining_Start();
		} else {

		}

		if (other.tag == "Ladder Training Exit") {
			gameManager.LadderTraining_Complete();
			// Ladder trainign manager -> complete steps

			
		}
		if (other.tag == "Toolbelt Training Start") {
			gameManager.ToolbeltTraining_Start();
			// Toolbelt trainign manager -> complete steps

			
		}
		if (other.tag == "Toolbelt Training Exit") {
			gameManager.ToolbeltTraining_Exit();
			// Toolbelt trainign manager -> complete steps

			
		}
		if (other.tag == "Lader Blinking Spot") {
			other.gameObject.SetActive(false);
			// Toolbelt trainign manager -> complete steps
		}
	}

	

	public void Teleport (Vector3 to) {
		// make blink effect here
		this.transform.position = to;
	}

}