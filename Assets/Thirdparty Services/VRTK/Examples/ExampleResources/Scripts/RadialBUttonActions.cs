using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace VRTK.Examples
{
    using UnityEngine;

    public class RadialBUttonActions : MonoBehaviour
    {
public GameObject CAMERA;
public GameObject TAPE;
public GameObject RightControllerModel;
public VRTK_StraightPointerRenderer StraightPointerRenderer;


public void UseCamera(){
	CAMERA.SetActive(true);
	TAPE.SetActive(false);
	RightControllerModel.SetActive(false);
	StraightPointerRenderer.enabled=false;
	
	
}
public void UseTape(){
	CAMERA.SetActive(false);
	TAPE.SetActive(true);
	RightControllerModel.SetActive(false);
	StraightPointerRenderer.enabled=false;
	
}
public void  UseController(){
	CAMERA.SetActive(false);
	TAPE.SetActive(false);
	RightControllerModel.SetActive(true);
	StraightPointerRenderer.enabled=true;

}
public void Update(){
	if(TAPE.activeInHierarchy){
		
	}
}

	}

}