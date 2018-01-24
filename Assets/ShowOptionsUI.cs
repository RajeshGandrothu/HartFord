



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOptionsUI : MonoBehaviour
{

  public GameObject OptionsUI;

    // Use this for initialization
    void Start()
    {

        if (GetComponent<VRTK.VRTK_ControllerEvents>() == null)
        {
            return;
        }

        GetComponent<VRTK.VRTK_ControllerEvents>().TriggerPressed += new VRTK.ControllerInteractionEventHandler(DoTriggerPressed);
		 GetComponent<VRTK.VRTK_ControllerEvents>().TriggerReleased += new VRTK.ControllerInteractionEventHandler(DoTriggerReleased);
    }


    private void DoTriggerPressed(object sender, VRTK.ControllerInteractionEventArgs e)
    {
       // gameManager.StartMobileCamera();
	   Debug.Log("Options UI Show");
	   OptionsUI.SetActive(true);
    }
	 private void DoTriggerReleased(object sender, VRTK.ControllerInteractionEventArgs e)
    {
       // gameManager.StartMobileCamera();
	   Debug.Log("Options UI Hide");
	    OptionsUI.SetActive(false);
    }
}