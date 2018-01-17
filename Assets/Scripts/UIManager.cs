using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject Player;

    #region Shingles UI objects
    public GameObject Shingles_Types_UI;
    public GameObject Shingles_Damages_UI;
    public GameObject Shingles_Replace_Repair_UI;

    #endregion

    void Start () {

    }

    void Update () {

    }

    // function to satrt learning. this is to be called from UI
    public void StartLearning () {
        // voice over for learning section.

        // show tools section
    }

    // function to satrt evaluation. this is to be called from UI
    public void StartEvaluation () {

    }

    #region Ladder training sections
    public void LadderTraining_Start () 
    {
       Debug.Log("LadderTraining_Start");   
    }
    public void LadderTraining_Complete () { }

    #endregion

    #region Tool belt training section
    public void ToolbeltTraining_Start () 
    {
        Debug.Log("ToolbeltTraining_Start");
     }
    public void ToolbeltTraining_Complete () { }

    // tools ui
    public void ToolBelt_Single_Tool_UI_Show (string name) {
        GameObject.Find (name).SetActive (true);
    }
    public void ToolBelt_Single_Tool_UI_Hide (string name) {
        GameObject.Find (name).SetActive (false);
    }

    #endregion

    #region Risk Shot section
    public void RiskShot_Start () {

    }
    public void RiskShot_Complete () {

    }
    #endregion

    #region Shingles training section
    public void ShinglesTraining_Start () {

    }

    public void Shingles_Toggle_Types_UI () {
        Toggle (this.Shingles_Types_UI);
    }

    public void Shingles_Toggle_Damages_UI () {
        Toggle (this.Shingles_Damages_UI);
    }

    public void Shingles_Toggle_Replace_Repair_UI () {
        Toggle (this.Shingles_Replace_Repair_UI);
    }

    public void ShinglesTraining_Complete () {

    }
    
    #endregion

    private void Toggle (GameObject gameObject) {
        if (gameObject.activeInHierarchy) {
            gameObject.SetActive (false);
        } else {
            gameObject.SetActive (true);
        }
    }

}