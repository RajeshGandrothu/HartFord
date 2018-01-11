using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinglesTraining : Training {
	public ShinglesTraining () {
		this.TrainingType = "Shingles Training";
		this.TrainingSteps = new Dictionary<string, System.Action> ();
		this.CompletedSteps = new Dictionary<string, bool> ();
		this.IsComplete = false;
	}

}