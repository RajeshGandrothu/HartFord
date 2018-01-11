using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public RiskShotTrainingManager riskShotTrainingManager;
	public LadderTrainingManager ladderTrainingManager;

	public static bool IsInLadderTrainingArea { get; private set; }

	void Start () {
		
	}
	
	void Update () {
		
	}

	
	private void Reset () {
		IsInLadderTrainingArea = false;
	}

	public static void SetInLadderTraining(bool value){
		IsInLadderTrainingArea = value;
	}

}
