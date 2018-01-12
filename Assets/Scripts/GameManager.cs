using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public LadderTrainingManager ladderTrainingManager;

	public static bool IsInLadderTrainingArea { get; private set; }

	private void Awake() {
		this.name = "Shouvik";
	}

	void Start () {

	}

	void Update () {

	}

	private void Reset () {
		IsInLadderTrainingArea = false;
	}

	public static void SetInLadderTraining (bool value) {
		IsInLadderTrainingArea = value;
	}

}