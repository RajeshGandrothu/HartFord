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
		tts.Speak("Welcome to the Virtual Risk Assessment training.");
	}

	public void ViveControlOverview(){
		tts.Speak("The panel in front of you shows how you can make the best use of your vive controllers.");
	}

	void OnApplicationQuit()
	{
		tts.Destory();
	}
}
