using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskShotTraining : Training {

	public RiskShotTraining(){
		this.TrainingType = "Risk Shot";
		this.TrainingSteps = new Dictionary<string, Action>();
		this.CompletedSteps = new Dictionary<string, bool>();
		this.IsComplete = false;
	}



}
