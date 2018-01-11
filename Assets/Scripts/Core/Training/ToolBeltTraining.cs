using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBeltTraining : Training {
	public ToolBeltTraining () {
		this.TrainingType = "Tool Belt Training";
		this.TrainingSteps = new Dictionary<string, System.Action> ();
		this.CompletedSteps = new Dictionary<string, bool> ();
		this.IsComplete = false;
	}
}