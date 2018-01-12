using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofVentAssesmentManager : AssesmentManager {

	private void Awake () {
		this.assesment = new RoofVentAssesment ();
	}
}