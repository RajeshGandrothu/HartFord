using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskShotTrainingManager : TrainingManager {

	private void Awake () {
		this.training = new RiskShotTraining ();
		this.training.TrainingSteps.Add ("Step 1", CompleteStep1);
	}

	void Start () {

	}

	void Update () {

	}

	public void CompleteStep1 () {
		Debug.Log ("step 1 completed");
	}

}