using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrainingManager : TrainingManager {

	public GameObject Ladder;

	private void Awake () {
		this.training = new LadderTraining ();
	}
	public void ShowLadder(){
		this.Ladder.SetActive(true);
    }
    public void HideLadder(){
		this.Ladder.SetActive(false);
    }

		public void Complete(){
			this.training.IsComplete = true;
		}

}