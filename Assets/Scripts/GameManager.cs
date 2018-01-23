
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public LadderTrainingManager ladderTrainingManager;
	public ToolBeltTrainingManager toolbeltTrainingManager;
	public GameObject CameraRig;
	public PlayerManager playerManager;
	public UIManager uiManager;
	public AudioManager audioManager;
	public MobileCameraCapture mobileCameraCapture;

	public Camera mobileCamera;

	
	/*camera capture functionality */

	private int imageNo;
    private RenderTexture renderTex;
    private int width = 500, height = 500;

/*camera capture functionality */
	private void Awake() {
		this.name = "Shouvik";
		renderTex = new RenderTexture(width, height, 24);
        mobileCamera.targetTexture = renderTex;
	}

	void Start () {

	}

	void Update () {

	}

	private void Reset () {
		ladderTrainingManager.training.IsComplete = false;
	}

	public void StartMobileCamera()
    {
        imageNo++;
        string filePath = Application.dataPath + "/screenshot_" + imageNo + ".png";
        File.WriteAllBytes(filePath, CaptureScreenshot().EncodeToPNG());
    }

    Texture2D CaptureScreenshot()
    {
        RenderTexture tempRT = RenderTexture.active;
        RenderTexture.active = renderTex;
        mobileCamera.Render();
        Texture2D screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
        screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        screenshot.Apply(false);
        RenderTexture.active = tempRT;
        return screenshot;
    }



	#region laddertraining region
	public void GoToLadderTraining(){
		// 1. voice over
		audioManager.GoToLadderTraining();

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