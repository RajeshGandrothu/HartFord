using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinglesAssesmentManager : AssesmentManager {

	private void Awake () {
		this.assesment = new ShinglesAssesment();
	}
}