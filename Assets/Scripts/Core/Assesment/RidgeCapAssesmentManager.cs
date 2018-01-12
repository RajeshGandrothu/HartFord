using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidgeCapAssesmentManager : AssesmentManager {

	private void Awake() {
		this.assesment = new RidgeCapAssesment();
	}
}
