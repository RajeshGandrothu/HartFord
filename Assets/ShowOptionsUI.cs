



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
    public bool IsPressed;

   public float speed;

    // Use this for initialization
    void Start()
    {
        CAMERA.SetActive(false);
        TAPE.SetActive(false);
        IsPressed=false;
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
    IsPressed=true;}
  

    }
	 private void DoTriggerReleased(object sender, VRTK.ControllerInteractionEventArgs e)
    {
      
	  IsPressed=false;
	   
    }
  
    void Update()
    {
        if(IsPressed){
          tape.transform.localScale=new Vector3(tape.transform.localScale.x, tape.transform.localScale.y, Mathf.MoveTowards(tape.transform.localScale.z, -MaxDistance, Time.deltaTime * -speed));
        }
        else{
        
         tape.transform.localScale=new Vector3(tape.transform.localScale.x, tape.transform.localScale.y, Mathf.MoveTowards(tape.transform.localScale.z, MinDistance, Time.deltaTime * speed));
        }
    }
}