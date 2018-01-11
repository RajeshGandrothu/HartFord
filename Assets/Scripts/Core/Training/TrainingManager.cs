﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingManager : MonoBehaviour {
	public Training training { get; set; }

	public void ResetTraining () {
		this.training.IsComplete = false;
	}

	public void CompleteTraining () {
		this.training.IsComplete = true;
	}
}