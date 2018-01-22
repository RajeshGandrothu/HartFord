
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public LadderTrainingManager ladderTrainingManager;
	public ToolBeltTrainingManager toolbeltTrainingManager;
	public GameObject CameraRig;
	public PlayerManager playerManager;
	public UIManager uiManager;
	private void Awake() {
		this.name = "Shouvik";
	}

	void Start () {

	}

	void Update () {

	}

	private void Reset () {
		ladderTrainingManager.training.IsComplete = false;
	}


	#region laddertraining region
	public void GoToLadderTraining(){
		// 1. voice over

		//2. Teleport
		CameraRig.transform.position=new Vector3(50,0,0);
	}
			
	public void LadderTraining_Complete(){
		// complete training
		ladderTrainingManager.Complete();
		ladderTrainingManager.HideLadder();
		// 1. Teleport
		CameraRig.transform.position=new Vector3(0,0,0);
		// 2. Show complete UI
		uiManager.LadderTraining_Complete();
		// 3. voice over
		
	}
	public void LadderTraining_Start(){
		// 1. voice over

		// 2. Show ladder
		ladderTrainingManager.ShowLadder();
		// 3. Instructions on ladder usage (voice over)
	}

	
		
	#endregion
	#region Toolbelt Training
	public void GoToToolbeltTraining(){
		// 1. voice over

		//2. Teleport
		CameraRig.transform.position=new Vector3(50,0,-12);
	}
		public void ToolbeltTraining_Start(){
		// 1. voice over

		// 2. Show Toolbelt
		toolbeltTrainingManager.ShowToolbelt();

		
		// 3. Instructions on Toolbelt usage (voice over)
	}
	public void ToolbeltTraining_Exit(){
		// 1. voice over

		// 2. Hide Toolbelt
		toolbeltTrainingManager.HideToolbelt();
		CameraRig.transform.position=new Vector3(0,0,0);
		toolbeltTrainingManager.Complete();
		uiManager.ToolbeltTraining_Complete();
		
		
		
	}
		
	#endregion

	#region Raycast in Risk Shot
		
		public void RayCast_RiskShot(){

		}

	#endregion

}