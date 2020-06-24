using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

[InitializeOnLoad]
public class TimeEditor
{
    static TimeEditor()
    {
        Debug.Log("Timer: Startup. " + Stopwatch.GetTimestamp() / (double)Stopwatch.Frequency);
        EditorApplication.playModeStateChanged += change => Debug.Log("Timer: Changing playmode. " + Stopwatch.GetTimestamp() / (double)Stopwatch.Frequency);
    }
}
