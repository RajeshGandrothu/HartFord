// *****************************************************************
// Voice to Unity3D DLL (c) ZJP
// *****************************************************************
#define EXPORT_API __declspec(dllexport)
#include "sapi.h"
#include <stdio.h>

ISpVoice* pVoice;
SPVOICESTATUS eventStatus;

extern "C" int EXPORT_API Uni_Voice_Init(){
    CoInitializeEx(NULL, COINIT_MULTITHREADED);
	// Create SAPI voice
	if(CoCreateInstance(CLSID_SpVoice, NULL, CLSCTX_ALL, IID_ISpVoice, (void**)&pVoice)){
        // Couldn't create voice.
        CoUninitialize();
        return 1;
	}
	return 0;
}

extern "C" int EXPORT_API Uni_Voice_Speak(LPWSTR texte)	{
	if(pVoice->lpVtbl->Speak(pVoice,  texte, SPF_ASYNC|SPF_IS_XML, NULL)){

		return 1;
	}
	return 0;
}

extern "C" int EXPORT_API Uni_Voice_SpeakEX(LPWSTR texte, int voiceFlag){
	if(pVoice->lpVtbl->Speak(pVoice, texte, voiceFlag, NULL)){
		return 1;
	}
	return 0;
}

extern "C" int EXPORT_API Uni_Voice_Status(int stat){
	pVoice->lpVtbl->GetStatus(pVoice, &eventStatus, NULL );
	ULONG voiceStat;

	switch ( stat )	{
        case 0:
            voiceStat = eventStatus.dwRunningState; // 2 = speak is running
            break;
        case 1:
            voiceStat = (eventStatus.ulInputWordPos) + 1; // start position of the actual speaked word
            break;
        case 2:
            voiceStat = (eventStatus.ulLastStreamQueued); // The number of the last stream queued.
            break;
        case 3:
            voiceStat = (eventStatus.ulCurrentStream); //The number of the current stream being synthesized or receiving output
            break;

        default:
             voiceStat = eventStatus.dwRunningState; // 2 = speak is running
            break;
    }
	return (int)voiceStat;
}

extern "C" int EXPORT_API Uni_Voice_Pause(){
	pVoice->lpVtbl->Pause(pVoice);
	return 0;
}

extern "C" int EXPORT_API Uni_Voice_Resume(){
	pVoice->lpVtbl->Resume(pVoice);
	return 0;
}


extern "C" int EXPORT_API Uni_Voice_Rate(int rate){
	pVoice->lpVtbl->SetRate(pVoice, rate );
	return 0;
}

extern "C" int EXPORT_API Uni_Voice_Volume(int volume){
	pVoice->lpVtbl->SetVolume(pVoice, volume );
	return 0;
}



extern "C" void EXPORT_API Uni_Voice_Close(){
	pVoice->lpVtbl->Release(pVoice);
	// Finish COM
	CoUninitialize();
}
// *****************************************************************
// Voice to Unity3D DLL (c) ZJP
// *****************************************************************
