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
        ShowToolsSection ();
    }

    // function to satrt evaluation. this is to be called from UI
    public void StartEvaluation () {

    }

    public void StartLadderTraning () {
        Player.transform.position = new Vector3 (50, 0, 0);
    }

    public void StartToolbeltTraining () {
        Player.transform.position = new Vector3 (50, 0, 0);
    }

    // screeen function
    public void ShowToolsSection () {

    }

}