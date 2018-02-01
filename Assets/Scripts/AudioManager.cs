using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    WindowsTTS tts;

    void Awake()
    {
        tts = new WindowsTTS();
    }
    public void RoofTopReachedCongratulations()
    {
        tts.Speak("Congrats ! You have successfully reached the rooftop");
        tts.Speak("Now we will be learning about the various roofing shingles . Select each material to know more");
    }

    public void GoToLadderTraining()
    {
        tts.Speak("We will take you to the ladder training area now");
    }

    public void NewGoalsIntro()
    {
        tts.Speak("Please, select an option to create a goal. We recomend you start with retirement planning");
    }

    public void Welcome()
    {
        tts.Speak("Welcome to the property adjuster training program . During the course of this program , we will be learning how to carry out field inspection and claims damage assessment");
    }

    public void ViveControlOverview()
    {
        tts.Speak("Lets have a look at how to operate the VR controls. Use the left controller to teleport to the desired location");
    }
    public void ToolsOverview()
    {
        tts.Speak("To begin with , we will take a look at the tools you will have to carry . Rotate the tool kit to view all the tools .");
    }

    public void AboutMetaltShingle()
    {
        tts.Speak("About Metal Shingle");
    }
    public void AboutTilesShingle()
    {
        tts.Speak("now you learn About Tiles type ofShingle");
    }
    public void AboutAsphaltShingle()
    {
        tts.Speak("now you learn About AsphaltShingle");
    }
    public void AboutWoodShingle()
    {
        tts.Speak("now you learn About Wood type of Shingle");
    }
    public void AboutSlateShingle()
    {
        tts.Speak("now you learn About Slate type of Shingle");
    }

    #region Damages

    public void AboutBruising_Shingle()
    {
        tts.Speak("To identify this damage , Go close to the highlighted area and touch the shingle  ");
    }
    public void AboutCracking_Shingle()
    {
        tts.Speak("To identify this damage , Go close to the highlighted area and touch the shingle ");
    }
    public void AboutMissing_Shingle()
    {
        tts.Speak("now you learn About Missing Shingle");
    }
    public void LearnAboutShinglesDamages()
    {
        tts.Speak("Now you will learn about Type of Damages. Select each of these damages to know more.");
    }
    public void GoToDamageAssesMent()
    {
        tts.Speak("Now that you are aware of the type of damages , Go to the highlighted spot and inspect the roof to assess the nature of damage on shingles.");
    }
	   public void StartDamageAssesment()
    {
        tts.Speak("To you right is the Damage Assessment area. Please select all the applicable damage types in the UI for your assessment.");
    }
    public void CompleteDamageAssesment()
    {
        tts.Speak("That’s correct. There is lot of cracking on few shingles and some shingles are missing ");
    }
	public void CompleteDamageAssesmentFirst()
    {
        tts.Speak("Please Complete the Damage Assessment First. And select Done. ");
    }
	public void AfterCrackingSound(){
		tts.Speak("This sound signifies that the shingle is cracked . Identify a few more cracking spots and take a picture with your camera ");
	}
    public void IdentifyBrusingShingles(){
		tts.Speak("yes this is Bruising Shingle ");
	}
    public void AfterIdentifyBrusingShingles(){
		tts.Speak(" Identify a few more cracking spots and take a picture with your camera ");
	}

    #endregion


    public void LaderTrainingcomplete_Voice()
    {
        tts.Speak("Lets climb up the ladder and to get to the roof. Hold the grip buttons of the controller and drag the rungs down.");
        tts.Speak("Ensure you are wearing a non-slip footwear to be safe.");
        tts.Speak("Be careful.");
    }
    public void LaderTrainingStart_Voice()
    {
        tts.Speak("Now you are in ladder training area,select the lader and climbs up using Grip buttons ");
    }
    public void TypeOfShingle()
    {
        tts.Speak("Now Identify the shingle type ");
    }

    public void CompletedShingleIdentification()
    {
        tts.Speak("That's correct,");
        tts.Speak("Now that you can identify the shingle type , lets learn about the damages caused by hail on the shingle");
    }

    public void StartTrainingProgram()
    {
        tts.Speak("Now that you are familiar  with all the tools , lets start the training program .");
    }
    public void SelctComponent()
    {
        tts.Speak("Please select a component you would like to learn abou.");
    }
    public void SelctRoofStyle()
    {
        tts.Speak("Which roof style do you want to go with");
    }

    void OnApplicationQuit()
    {
        tts.Destory();
    }
}
