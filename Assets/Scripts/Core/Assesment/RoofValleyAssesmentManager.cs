using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofValleyAssesmentManager : AssesmentManager {

	private void Awake () {
		this.assesment = new RoofValleyAssesmnent ();
	}
}