using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : Singleton<Gamemanager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    void Start()
    {
        _sessionStartTime = DateTime.Now;
        Debug.Log($"Game session started at: {_sessionStartTime}");
    }

    private void NextScene()
    {
        _sessionEndTime = DateTime.Now;

        TimeSpan sessionDuration = _sessionStartTime - _sessionEndTime;
        Debug.Log($"Game session ende at: {_sessionEndTime}");
        Debug.Log($"Total session duration: {sessionDuration}");
    }

    /*void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            NextScene();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }*/
}
