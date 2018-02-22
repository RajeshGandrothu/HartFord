using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBeltTrainingManager : TrainingManager {
	public GameObject Toolbelt;
	private void Awake () {
		this.training = new ToolBeltTraining ();
	}
	public void ShowToolbelt(){
		this.Toolbelt.SetActive(true);
	}
	public void HideToolbelt(){
		//this.Toolbelt.SetActive(false);
		
	}
	public void Complete(){
			this.training.IsComplete = true;
		}
}