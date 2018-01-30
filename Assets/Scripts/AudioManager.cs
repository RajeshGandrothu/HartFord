using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	WindowsTTS tts;

	void Awake()
	{
		tts = new WindowsTTS();
	}

	public void GoToLadderTraining(){
		tts.Speak("We will take you to the ladder training area now");
	}

	public void NewGoalsIntro(){
		tts.Speak("Please, select an option to create a goal. We recomend you start with retirement planning");
	}

	public void Welcome(){
		tts.Speak("Welcome to the property adjuster training program . During the course of this program , we will be learning how to carry out field inspection and claims damage assessment");
	}

	public void ViveControlOverview(){
		tts.Speak("Lets have a look at how to operate the VR controls. Use the left controller to teleport to the desired location");
	}
	public void ToolsOverview(){
		tts.Speak("To begin with , we will take a look at the tools you will have to carry . Rotate the tool kit to view all the tools .");
	}

	public void AboutMetaltShingle(){
		tts.Speak("About Metal Shingle");
	}
	public void AboutTilesShingle(){
		tts.Speak("now you learn About Tiles type ofShingle");
	}
	public void AboutAsphaltShingle(){
		tts.Speak("now you learn About AsphaltShingle");
	}
	public void AboutWoodShingle(){
		tts.Speak("now you learn About Wood type of Shingle");
	}
	public void AboutSlateShingle(){
		tts.Speak("now you learn About Slate type of Shingle");
	}
	public void ChoosingAsphalt(){
		tts.Speak("That's correct,");
	}
	public void AboutBruising_tShingle(){
		tts.Speak("now you learn About Bruising Shingle");
	}
	public void AboutCracking_Shingle(){
		tts.Speak("now you learn About Cracking Shingle");
	}
	public void AboutMissing_Shingle(){
		tts.Speak("now you learn About Missing Shingle");
	}
	public void Choose_Cracking(){
		tts.Speak("That's correct,");
	}
	public void LaderTrainingcomplete_Voice(){
	

		tts.Speak("Lets climb up the ladder and to get to the roof. Hold the grip buttons of the controller and drag the rungs down.");
		tts.Speak("Ensure you are wearing a non-slip footwear to be safe.");
		tts.Speak("Be careful.");
	}
	public void LaderTrainingStart_Voice(){
		tts.Speak("Now you are in ladder training area,select the lader and climbs up using Grip buttons ");
	}
	public void TypeOfShingle(){
		tts.Speak("Now Identify the shingle type ");
	}

	public void StartTrainingProgram(){
		tts.Speak("Now that you are familiar  with all the tools , lets start the training program .");
	}
	public void SelctComponent(){
		tts.Speak("Please select a component you would like to learn abou.");
	}
	public void SelctRoofStyle(){
		tts.Speak("Which roof style do you want to go with");
	}
	public void LearnAboutShinglesDamages(){
		tts.Speak("Now you learn about Type of Damages");
	}
	


	void OnApplicationQuit()
	{
		tts.Destory();
	}
}
