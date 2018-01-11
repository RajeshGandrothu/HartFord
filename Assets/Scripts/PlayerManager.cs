using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public RiskShotTrainingManager riskShotTrainingManager;
	public LadderTrainingManager ladderTrainingManager;

	private bool IsInLadderTrainingArea = false;

	// Use this for initialization
	void Awake () {
		Invoke ("Intro", 10f);
	}

	// Update is called once per frame
	void Update () {

	}

	void Intro () {
		// this.riskShotTrainingManager.TrainingSteps["Step 1"]
	}

	private void OnTriggerEnter (Collider other) {
		if (other.tag == "Ladder Training Area" && !IsInLadderTrainingArea) {
			IsInLadderTrainingArea = true;
		} else {
			Reset ();
		}


		if(other.tag == "Ladder Training Goal"){
			// Ladder trainign manager -> complete steps
			ladderTrainingManager.CompleteTraining();

			// teleport
		}
	}

	private void Reset () {
		IsInLadderTrainingArea = false;
	}


	public void Teleport(Vector3 to){
		// make blink effect here
		this.transform.position = to;
	}

}