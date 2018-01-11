﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskShotTrainingManager : MonoBehaviour {

	public RiskShotTraining training { get; private set; }
	
	private void Awake() {
		this.training = new RiskShotTraining();

		this.training.TrainingSteps.Add("Step 1", CompleteStep1);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CompleteStep1(){
		Debug.Log("step 1 completed");
	}

	public void CompleteTraining(){
		this.training.IsComplete = true;
	}
}
