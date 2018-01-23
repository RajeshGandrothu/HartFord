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

	void OnApplicationQuit()
	{
		tts.Destory();
	}
}
