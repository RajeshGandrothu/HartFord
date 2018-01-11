using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinglesTrainingManager : TrainingManager {

	private void Awake () {
		this.training = new ShinglesTraining ();
	}

}