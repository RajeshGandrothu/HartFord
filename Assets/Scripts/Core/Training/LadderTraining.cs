using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTraining : Training {

	public LadderTraining () {
		this.TrainingType = "Ladder Training";
		this.TrainingSteps = new Dictionary<string, System.Action> ();
		this.CompletedSteps = new Dictionary<string, bool> ();
		this.IsComplete = false;
	}

}