using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrainingManager : TrainingManager {

	private void Awake () {
		this.training = new LadderTraining ();
	}

}