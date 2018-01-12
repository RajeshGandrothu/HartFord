using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject Player;

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

    #region Ladder training Sections
    public void LadderTraining_Start () {
        Player.transform.position = new Vector3 (50, 0, 0);
    }
    public void LadderTraining_Complete () { }

    #endregion

    #region Tool belt training section
    public void ToolbeltTraining_Start () { }
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
    public void ShinglesTraining_Complete () {

    }
    #endregion

}