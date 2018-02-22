using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

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
     public GameObject NextForTools;

     public GameObject Button1;
     public GameObject Button2;
     public GameObject Button3;
     public GameObject Button4;
     public GameObject Button5;
     public GameObject Cracking_Shingles_UI;
     public GameObject Missing_Shingles_UI;
     
    
    public Transform Startingposition;
    public Transform Laderposition;
    public Transform RoofCentergposition;
    public Transform ShinglesAssessmentposition;
     public Transform MeasurmentPosition;

    private  int photo=0;
    private  int LearningCount=0;
    public PlayerManager playerManager;
    public UIManager uiManager;
    public AudioManager audioManager;
    public MobileCameraCapture mobileCameraCapture;
    public Camera mobileCamera;
    private int ToolsCount;

    private int imageNo;
    private int width = 512, height = 256;

    private void Awake()
    {

    }

    void Start()
    {
        audioManager.Welcome();
        ToolsCount=0;

    }
    public void ViveControlOverview()
    {
        audioManager.ViveControlOverview();
    }


    void Update()
    {

    }
    public void cameraOverViwe(){
        if((NextForTools.activeInHierarchy)&&(ToolsCount!=2)){
            ToolsCount+=1;
        audioManager.YesCamare();
        }
    }
       public void TapeOverViwe(){
        if((NextForTools.activeInHierarchy)&&(ToolsCount!=2)){
            ToolsCount+=1;
        audioManager.YesTape();
        }
    }
       public void ModeChangetoController(){
        if((NextForTools.activeInHierarchy)&&(ToolsCount==2)){
           
        audioManager.ChaneModetoController();
        NextForTools.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
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
         if((photo==1)&&(NextForTools.activeInHierarchy)){
           audioManager.SelectTape();
           
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
   public void MoveToMeasuringPosition()
{
     CameraRig.transform.position = MeasurmentPosition.transform.position;
}
    #region ShowDiff Roofs
    public void ShowMetalRoof(){
        MetalRoof.SetActive(true);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
        Invoke("ShowButtion3",3f);
    }
     public void ShowWoodRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(true);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
        Invoke("ShowButtion1",3f);
       

    }
     public void ShowSlateRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(true);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(false);
         Invoke("ShowButtion4",3f);
    }
     public void ShowTileRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(true);
        AsphaltRoof.SetActive(false);
        Invoke("ShowButtion2",3f);
    }
      public void ShowAsphaltRoof(){
        MetalRoof.SetActive(false);
        WoodRoof.SetActive(false);
        SlateRoof.SetActive(false);
         TileRoof.SetActive(false);
        AsphaltRoof.SetActive(true);
         Invoke("ShowButtion5",3f);
         
    }
    public void ShowBruisingShingles(){
        BruisingShingles.SetActive(true);
        CrackingShingles.SetActive(false);
        Cracking_Shingles_UI.GetComponent<Button>().interactable=true;
        }
         public void ShowCrackingShingles(){
       CrackingShingles.SetActive(true);
       BruisingShingles.SetActive(false);
       Missing_Shingles_UI.GetComponent<Button>().interactable=true;
         }
         public void ShowMissingShingles(){
              BruisingShingles.SetActive(false);
              CrackingShingles.SetActive(false);
         }
    #endregion

    void ShowButtion1(){
        Button1.gameObject.GetComponent<Button>().interactable=true;
    }
     void ShowButtion2(){
        Button2.gameObject.GetComponent<Button>().interactable=true;
    }
     void ShowButtion3(){
        Button3.gameObject.GetComponent<Button>().interactable=true;
    }
     void ShowButtion4(){
        Button4.gameObject.GetComponent<Button>().interactable=true;
    }
     void ShowButtion5(){
        Button5.gameObject.GetComponent<Button>().interactable=true;
    }

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
       // toolbeltTrainingManager.HideToolbelt();
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