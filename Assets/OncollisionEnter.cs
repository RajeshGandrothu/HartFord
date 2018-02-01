using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionEnter : MonoBehaviour {

	// Use this for initialization
	public AudioManager AudioManager;
	public UIManager uiManager;
	public AudioSource Cracking;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		
		if(other.gameObject.tag=="Cracking"){
			Debug.Log("Crackinggggggggggggggggg Soundddddddddddddddddddddd");
			Cracking.Play();
		}
		if(other.gameObject.tag=="Bruising"){
			
		AudioManager.IdentifyBrusingShingles();
		}
		if(other.gameObject.tag=="Pouch"){
			other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
		}
		

	}
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag=="Cracking"){
			AudioManager.AfterCrackingSound();
			Cracking.Stop();
			uiManager.NextPanel("Cracking IdentifivcationDone");

		}
		if(other.gameObject.tag=="Bruising"){
			
		AudioManager.AfterIdentifyBrusingShingles();
		uiManager.NextPanel("Cracking IdentifivcationDone");
		}
		if(other.gameObject.tag=="Pouch"){
			other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
		}
	//	Debug.Log("Crackinggggggggggggggggg Soundddddddddddddddddddddd Stoppppppppp");
		

	}
}
