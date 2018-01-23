
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

public class WindowsTTS
{
    [DllImport("WindowsVoice")]
    public static extern void initSpeech();
    [DllImport("WindowsVoice")]
    public static extern void destroySpeech();
    [DllImport("WindowsVoice")]
    public static extern void addToSpeechQueue(string s);

    public WindowsTTS()
    {
        initSpeech();
    }

    ~WindowsTTS()
    {
        destroySpeech();
    }

    public void Speak(string toSay)
    {
        addToSpeechQueue(toSay);
    }

    public void Destory(){
        destroySpeech();
    }
}
