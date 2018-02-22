using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour {

	
	public GameObject UIButton;
	public int time;
	// Update is called once per frame

	public void Start()
	{
		UIButton.gameObject.SetActive(false);
	}
	void Update () {
		if(this.gameObject.activeInHierarchy){
		Invoke("ButtonActive",time);
			
			}
		}

	public void ButtonActive(){
		UIButton.gameObject.SetActive(true);
	}
	}
	

