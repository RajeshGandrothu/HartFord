using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	 public GameManager gameManager;
	 public UIManager uimanager;
	  public AudioManager audioManager;
	 public GameObject TeliportArea;
	public GameObject DestinationPoint1;
	public GameObject DestinationPoint2;
	public GameObject DestinationPoint3;


	void Awake () {
		Invoke ("Intro", 10f);
	}

	void Update () {

	}

	void Intro () { }
	 
	 public void ShowTeliportArea(){
	TeliportArea.SetActive(true);
	}

	void OnTriggerEnter (Collider other) {
		// Debug.Log(other.tag);
		if (other.tag == "Ladder Training Enter") {
			gameManager.LadderTraining_Start();
		} else {

		}

		if (other.tag == "Ladder Training Exit") {
			gameManager.LadderTraining_Complete();
			// Ladder trainign manager -> complete steps

			
		}
		if (other.tag == "Toolbelt Training Start") {
			gameManager.ToolbeltTraining_Start();
			// Toolbelt trainign manager -> complete steps

			
		}
		if (other.tag == "Toolbelt Training Exit") {
			gameManager.ToolbeltTraining_Exit();
			// Toolbelt trainign manager -> complete steps

			
		}
		if (other.tag == "Ladder Blinking Spot") {
			other.gameObject.SetActive(false);
			// Toolbelt trainign manager -> complete steps
		}
		if(other.gameObject.name == "RoofEnterTrigger"){
			gameManager.ReachedRoofTop();
		}

		if(other.gameObject.name == "Damage Assessment Trigger"){
			gameManager.StartDamageAssessment();
		}

		if(other.gameObject.tag == "TeliTest"){
			if(other.gameObject.name=="DestinationPoint1"){
				other.gameObject.SetActive(false);
				DestinationPoint2.SetActive(true);
			}
		}
		if(other.gameObject.tag == "TeliTest"){
			if(other.gameObject.name=="DestinationPoint2"){
				other.gameObject.SetActive(false);
				DestinationPoint3.SetActive(true);
			}
		}
		if(other.gameObject.tag == "TeliTest"){
			if(other.gameObject.name=="DestinationPoint3"){
				uimanager.NextPanel("NextBTN_ui");
				other.gameObject.SetActive(false);
				audioManager.TrySelecting();
				TeliportArea.SetActive(false);
				
				
			}
		}
		
	}

	

	public void Teleport (Vector3 to) {
		// make blink effect here
		this.transform.position = to;
	}

}