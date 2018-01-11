using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBeltTrainingManager : TrainingManager {

	private void Awake () {
		this.training = new ToolBeltTraining ();
	}
}