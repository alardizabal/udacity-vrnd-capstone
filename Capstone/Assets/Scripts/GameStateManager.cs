using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public GameObject birds;
    public LaunchLavaBomb launcher;
    public AudioSource introAudio;
    public AudioSource youWinAudio;
    public AudioSource youLostAudio;
    private bool isPlaying = false;
    private float timeLeft = 10.0f;

    void Start()
    {
        //introAudio.Play();
    }

    void Update()
    {
        if (!isPlaying)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                isPlaying = true;
                StartPlaying();
            }
        }
    }

    private void StartPlaying()
    {
        SunRotate.shouldRotate = true;
        launcher.StartLavaBombLauncher();
    }

    public void PlayerWon()
    {
        Logger.Log("Player Won");
        birds.SetActive(true);
        launcher.StopLavaBombLauncher();
        SunRotate.shouldRotate = false;
        youWinAudio.Play();
    }

    public void PlayerLost()
    {
        Logger.Log("Player Lost");
        launcher.StopLavaBombLauncher();
        SunRotate.shouldRotate = false;
        //youLostAudio.Play();
    }

}
