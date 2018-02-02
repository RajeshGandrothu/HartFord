using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public LadderTrainingManager ladderTrainingManager;
    public ToolBeltTrainingManager toolbeltTrainingManager;
    public GameObject CameraRig;
    public GameObject DamageAssesmentTrigger;
    public GameObject RoofEnterTrigger;
    public GameObject MetalRoof;
    public GameObject WoodRoof;
    public GameObject SlateRoof;
    public GameObject TileRoof;
    public GameObject AsphaltRoof;
    public GameObject HilightSpot;
    public GameObject NextButton;
    public GameObject NextButton_Learning;
    public AudioSource CapturingSound;
    public GameObject GameCamrea;
    public GameObject BruisingShingles;
     public GameObject CrackingShingles;
    public Transform Startingposition;
    public Transform Laderposition;
    public Transform RoofCentergposition;
    public Transform ShinglesAssessmentposition;

    private  int photo=0;
    private  int LearningCount=0;
    public PlayerManager playerManager;
    public UIManager uiManager;
    public AudioManager audioManager;
    public MobileCameraCapture mobileCameraCapture;
    public Camera mobileCamera;

    private int imageNo;
    private int width = 512, height = 256;

    private void Awake()
    {

    }

    void Start()
    {
        audioManager.Welcome();

    }
    public void ViveControlOverview()
    {
        audioManager.ViveControlOverview();
    }


    void Update()
    {

    }

    private void Reset()
    {
        ladderTrainingManager.training.IsComplete = false;
    }


    public void CaptureScreenshot()
    {
        if(GameCamrea.activeInHierarchy){
            CapturingSound.Play();
            photo+=1;
        }
        if((photo==4)&&(BruisingShingles.activeInHierarchy)){

            audioManager.AfterTakingPictures();
            NextButton.SetActive(true);
            photo=0;
        }
        if((photo==4)&&(CrackingShingles.activeInHierarchy)){
           audioManager.AfterTakingPictures();
           NextButton.SetActive(true);
           photo=0;
           
        }
        
        Debug.Log("screenshot trigger pressed");
        RenderTexture tempRT = RenderTexture.active;
        RenderTexture.active = mobileCamera.targetTexture;
        Texture2D screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
        screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        screenshot.Apply(false);
        RenderTexture.active = tempRT;
        imageNo++;
        string filePath = Application.dataPath + "/screenshot_" + imageNo + ".png";
        File.WriteAllBytes(filePath, screenshot.EncodeToPNG());
    }

    #region laddertraining region
    public void GoToLadderTraining()
    {
        // 1. voice over
        audioManager.GoToLadderTraining();

        //2. Teleport
        CameraRig.transform.position = new Vector3(50, 0, 0);
    }

    public void LadderTraining_Complete()
    {
        // complete training
        ladderTrainingManager.Complete();
        ladderTrainingManager.HideLadder();
        // 1. Teleport
        CameraRig.transform.position = Laderposition.transform.position;
        // 2. Show complete UI
        uiManager.LadderTraining_Complete();
        // 3. voice over

    }
    public void LadderTraining_Start()
    {
        // 1. voice over

        // 2. Show ladder
        ladderTrainingManager.ShowLadder();
        // 3. Instructions on ladder usage (voice over)
    }
    public void MovetoRoofCenter()
{
     CameraRig.transform.position = RoofCentergposition.transform.position;
     LearningCount+=1;
     Debug.Log(LearningCount);
     if(LearningCount==2){
         NextButton.SetActive(false);
         NextButton_Learning.SetActive(true);
        
         Debug.Log("learningggggggggg");
     }
}
    public void MoveToStartingPosition()
{
     CameraRig.transform.position = Startingposition.transform.position;
}
    public void MoveToLadderPosition()
{
     CameraRig.transform.position =Laderposition.transform.position;
}
   public void MoveToShinglesAssesmentPosition()
{
     CameraRig.transform.position = ShinglesAssessmentposition.transform.position;
}
    #region ShowDiff Roofs
    public void ShowMetalRoof(){
        MetalRoof.SetActive(true);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
    }
     public void ShowWoodRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(true);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
    }
     public void ShowSlateRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(true);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
    }
     public void ShowTileRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(true);
        AsphaltRoof.SetActive(false);
    }
      public void ShowAsphaltRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(true);
    }
    public void ShowBruisingShingles(){
        BruisingShingles.SetActive(true);
        CrackingShingles.SetActive(false);
        }
         public void ShowCrackingShingles(){
       CrackingShingles.SetActive(true);
       BruisingShingles.SetActive(false);
         }
         public void ShowMissingShingles(){
              BruisingShingles.SetActive(false);
              CrackingShingles.SetActive(false);
         }
    #endregion



    #endregion

    #region Toolbelt Training
    public void GoToToolbeltTraining()
    {
        // 1. voice over

        //2. Teleport
        CameraRig.transform.position = new Vector3(50, 0, -12);
    }
    public void ToolbeltTraining_Start()
    {
        // 1. voice over

        // 2. Show Toolbelt
        toolbeltTrainingManager.ShowToolbelt();


        // 3. Instructions on Toolbelt usage (voice over)
    }
    public void ToolbeltTraining_Exit()
    {
        // 1. voice over

        // 2. Hide Toolbelt
        toolbeltTrainingManager.HideToolbelt();
        CameraRig.transform.position = new Vector3(0, 0, 0);
        toolbeltTrainingManager.Complete();
        uiManager.ToolbeltTraining_Complete();
    }

    #endregion

    #region Raycast in Risk Shot

    #region Go To House

    public void GoToHouse()
    {
        CameraRig.transform.position = new Vector3(-18, -15, 57);
        CameraRig.transform.Rotate(new Vector3(0, 100, 0));
        // playerManager.Teleport(new Vector3(12,0,0));
    }
    #endregion

    #region roof top

    public void ReachedRoofTop()
    {
        audioManager.RoofTopReachedCongratulations();
        RoofEnterTrigger.SetActive(false);
    }
    #endregion

    #region Damage Assesments

    public void StartDamageAssessment()
    {
        uiManager.NextPanel("Choose Type of Shingles_Damages_UI");
        audioManager.StartDamageAssesment();
    }
    public void CompleteDamageAssessment(){
        audioManager.CompleteDamageAssesment();
        DamageAssesmentTrigger.SetActive(false);
        RoofEnterTrigger.SetActive(false);


    }
     public void CompleteDamageAssessmentFirst(){
         audioManager.CompleteDamageAssesmentFirst();


    }
    #endregion

    #endregion

}