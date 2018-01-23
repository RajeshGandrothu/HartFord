using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameManager gameManager;

    #region Shingles UI objects
    public GameObject[] UI_Panels;
    public GameObject toolBelt;

    private GameObject BG;
    private int zRotationAngle = 0;
    private Vector3 targetZAxis = new Vector3(0, 0, 1);   


    #endregion

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        BG = GameObject.Find("BG");
    }

    void Start()
    {
        NextPanel("Vive Conrtols Overview");
    }
    /*padmini */
    
    public void RotateToolBelt(string direction)
    {
        if (direction == "right")
        {
            zRotationAngle = 90;
        }
        else if (direction == "left")
        {
            zRotationAngle = -90;
        }

        StartCoroutine(RotateToolBelt(targetZAxis, zRotationAngle, 1.0f));
    }

    IEnumerator RotateToolBelt(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = toolBelt.transform.rotation;
        Quaternion to = toolBelt.transform.rotation;
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            toolBelt.transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        toolBelt.transform.rotation = to;
    }
       /*padmini */



    

    void Update()
    {

    }

    // function to satrt learning. this is to be called from UI
    public void StartLearning()
    {
        // voice over for learning section.

        // show tools section
    }

    // function to satrt evaluation. this is to be called from UI
    public void StartEvaluation()
    {

    }

    #region Utilities
    public void DisbaleAllUI()
    {
        for (int i = 0; i < UI_Panels.Length; i++)
        {
            UI_Panels[i].gameObject.SetActive(false);
        }
    }

    public void EnableUI(string name)
    {
        for (int i = 0; i < UI_Panels.Length; i++)
        {
            if (UI_Panels[i].gameObject.name == name)
            {
                UI_Panels[i].gameObject.SetActive(true);
                break;
            }
        }
    }

    #endregion

    #region Ladder training sections
    public void GoToLadderTraining()
    {
        gameManager.GoToLadderTraining();

    }
    public void LadderTraining_Complete()
    {
        //show ui ladder training comlete......
    }

    #endregion

    #region About Shingles Type

    public void AboutShingleType_Asphalt()
    { //vioce over about this
    }
    public void AboutShingleType_Metal()
    {//vioce over about this
    }
    public void AboutShingleType_Slate()
    {//vioce over about this
    }
    public void AboutShingleType_Tiles()
    {//vioce over about this
    }
    public void AboutShingleType_Wood()
    {//vioce over about this
    }


    #endregion
    #region About Shingles Damage Type

    public void About_DamageShingleType_Bruising() { }
    public void About_DamageShingleType_Cracking() { }
    public void About_DamageShingleType_Missing() { }



    #endregion

    #region Tool belt training section
    public void GoToToolbeltTraining()
    {
        gameManager.GoToToolbeltTraining();

    }
    public void ToolbeltTraining_Start()
    {
        Debug.Log("ToolbeltTraining_Start");
    }
    public void ToolbeltTraining_Complete()
    {
        //Show next UI
    }

    // tools ui
    public void ToolBelt_Single_Tool_UI_Show(string name)
    {
        GameObject.Find(name).SetActive(true);
    }
    public void ToolBelt_Single_Tool_UI_Hide(string name)
    {
        GameObject.Find(name).SetActive(false);
    }

    #endregion

    #region Risk Shot section
    public void RiskShot_Start()
    {

    }
    public void RiskShot_Complete()
    {

    }
    #endregion

    #region Shingles training section
    public void ShinglesTraining_Start()
    {

    }

    public void Shingles_Toggle_Types_UI()
    {
        // Toggle (this.Shingles_Types_UI);
    }

    public void Shingles_Toggle_Damages_UI()
    {
        // Toggle (this.Shingles_Damages_UI);
    }

    public void Shingles_Toggle_Replace_Repair_UI()
    {
        // Toggle (this.Shingles_Replace_Repair_UI);
    }

    public void ShinglesTraining_Complete()
    {

    }

    #endregion


    #region Story Board

    public void NextPanel(string name){
         DisbaleAllUI();
        EnableUI(name);
        BG.SetActive(true);
    }

    #endregion
    private void Toggle(GameObject gameObject)
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

}