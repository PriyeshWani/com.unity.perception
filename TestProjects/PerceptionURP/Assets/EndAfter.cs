using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAfter : MonoBehaviour
{
    public int totalFrames = 1000;

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == totalFrames)
        {
            Debug.Log($"total time: {Time.realtimeSinceStartup}  FPS: {Time.frameCount / Time.realtimeSinceStartup}");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
