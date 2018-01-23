using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCameraCapture : MonoBehaviour
{

    public GameManager gameManager;

    // Use this for initialization
    void Start()
    {

        if (GetComponent<VRTK.VRTK_ControllerEvents>() == null)
        {
            return;
        }

        GetComponent<VRTK.VRTK_ControllerEvents>().TriggerPressed += new VRTK.ControllerInteractionEventHandler(DoButtonOnePressed);
    }


    private void DoButtonOnePressed(object sender, VRTK.ControllerInteractionEventArgs e)
    {
        gameManager.StartMobileCamera();
    }
}
