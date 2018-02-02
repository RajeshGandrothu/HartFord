using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionEnter : MonoBehaviour {

	// Use this for initialization
	public AudioManager AudioManager;
	public GameManager gameManager;
	public UIManager uiManager;
	public AudioSource Cracking;
	 private  int CrackSoundCount;
	
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
			CrackSoundCount+=1;
			
		}
		if(other.gameObject.tag=="Bruising"){
			
		AudioManager.IdentifyBrusingShingles();
		}
		if(other.gameObject.tag=="Pouch"){
			other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
		}
		if(other.gameObject.name == "RoofEnterTrigger"){
			gameManager.ReachedRoofTop();
		}
		

	}
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag=="Cracking"){
			if(CrackSoundCount==1){
				AudioManager.AfterCrackingSound();
			}
			
			Cracking.Stop();
			

		}
		if(other.gameObject.tag=="Bruising"){
			
		AudioManager.AfterIdentifyBrusingShingles();
		
		}
		if(other.gameObject.tag=="Pouch"){
			other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
		}
	//	Debug.Log("Crackinggggggggggggggggg Soundddddddddddddddddddddd Stoppppppppp");
		

	}
}
