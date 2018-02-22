
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasuringTapeBehaviour : MonoBehaviour {

	// Use this for initialization
	public AudioManager AudioManager;
	public GameManager gameManager;
	public UIManager uiManager;
	public Text text;
	public int a;
	 public Transform tape;
	
	public int t;

	
	void Start () {
			t=0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		
		if((other.gameObject.tag=="Length")&&(t!=1)){
			Debug.Log("Lenghts");
			t+=1;
			AudioManager.LengthCaptured();
			other.gameObject.SetActive(false);
			a=50;
			text.text=a.ToString();
		}
		if((other.gameObject.tag=="Width")&&(t!=1)){
			t+=1;
			Debug.Log("Width");
			AudioManager.WidthCaptured();
			other.gameObject.SetActive(false);
			a=30;
			text.text=a.ToString();

		}
		
		

	}
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag=="Lenght"){
			AudioManager.CompletedMeasurmentTraining();
			uiManager.NextPanel("MeasurmentOptions_UI");
			a=50;
			text.text=a.ToString();
		}
		if(other.gameObject.tag=="Width"){
			AudioManager.CompletedMeasurmentTraining();
			a=30;
			text.text=a.ToString();
			uiManager.NextPanel("MeasurmentOptions_UI");
		}
			

	}
}
