using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsBehaviour : MonoBehaviour {

	public GameObject[] Buttons;
	// Use this for initialization
	void Start () {
	
		for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].gameObject.GetComponent<Button>().interactable=false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		 Buttons[0].gameObject.GetComponent<Button>().interactable=true;
		
	}
}
