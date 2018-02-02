



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOptionsUI : MonoBehaviour
{

  public GameObject CAMERA;
  public GameObject TAPE;
  public Transform tape;

    public float MaxDistance;
    public float MinDistance;
    public bool FwdPressed;
    public bool BackPressed;

   public float speed;

    // Use this for initialization
    void Start()
    {
        CAMERA.SetActive(false);
        TAPE.SetActive(false);
        FwdPressed=false;
        BackPressed=false;
        if (GetComponent<VRTK.VRTK_ControllerEvents>() == null)
        {
            return;
        }

        GetComponent<VRTK.VRTK_ControllerEvents>().TriggerPressed += new VRTK.ControllerInteractionEventHandler(DoTriggerPressed);
		 GetComponent<VRTK.VRTK_ControllerEvents>().TriggerReleased += new VRTK.ControllerInteractionEventHandler(DoTriggerReleased);
         
    }


    private void DoTriggerPressed(object sender, VRTK.ControllerInteractionEventArgs e)
    {
   if(TAPE.activeInHierarchy){
    FwdPressed=true;}
  

    }
	 private void DoTriggerReleased(object sender, VRTK.ControllerInteractionEventArgs e)
    {
      
	  FwdPressed=false;
	   
    }
  
    void Update()
    {
        if(tape.transform.localScale.z>=20f){
           
        }
        if(FwdPressed)
        {
          tape.transform.localScale=new Vector3(tape.transform.localScale.x, tape.transform.localScale.y, Mathf.MoveTowards(tape.transform.localScale.z, -MaxDistance, Time.deltaTime * -speed));
        }
        if(BackPressed)
        {
        tape.transform.localScale=new Vector3(tape.transform.localScale.x, tape.transform.localScale.y, Mathf.MoveTowards(tape.transform.localScale.z, MinDistance, Time.deltaTime * speed));
        }
    }
    public void ForwardTape(){
         FwdPressed=true;
    }
    public void ForwardStop(){
       FwdPressed=false;
    }
    public void BackwardTape(){
         BackPressed=true;
    }
    public void BackwardStop(){
       BackPressed=false;
    }
}