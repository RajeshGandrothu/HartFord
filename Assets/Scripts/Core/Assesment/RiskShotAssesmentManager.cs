using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskShotAssesmentManager : AssesmentManager {

	private void Awake () {
		this.assesment = new RiskShotAssesmnet ();
	}
}