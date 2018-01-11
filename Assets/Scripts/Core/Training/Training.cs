using System;
using System.Collections;
using System.Collections.Generic;

public class Training {

	public bool IsComplete { get; set; }
	public string TrainingType { get; set; }
	public Dictionary<string, Action> TrainingSteps { get; set; }
	public Dictionary<string, bool> CompletedSteps { get; set; }

}