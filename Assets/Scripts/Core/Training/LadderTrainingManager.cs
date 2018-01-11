using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrainingManager : MonoBehaviour {

	public LadderTraining training { get; private set; }

	private void Awake() {
		this.training = new LadderTraining();
	}


	public void CompleteTraining(){
		this.training.IsComplete = true;
	}
	
}
