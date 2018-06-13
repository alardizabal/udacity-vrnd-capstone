using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public GameObject birds;
    public LaunchLavaBomb firstLauncher;
    public LaunchLavaBomb secondLauncher;
    public AudioSource introAudio;
    public AudioSource youWinAudio;
    public AudioSource youLostAudio;
    private bool isPlaying = false;
    private bool hasPlayedIntro = false;
    private bool hasPlayedYouLostAudio = false;
    private float introDelay = 10.0f;
    private float restartDelay = 10.0f;
    private bool didLose = false;
    
    void FixedUpdate()
    {
        if (!isPlaying)
        {
            introDelay -= Time.deltaTime;
            if (introDelay < 8.0f && !hasPlayedIntro)
            {
                introAudio.Play();
                hasPlayedIntro = true;
            }
            if (introDelay < 0)
            {
                isPlaying = true;
                StartPlaying();
            }
        }
        else
        {
            if (didLose)
            {
                restartDelay -= Time.deltaTime;
                if (restartDelay < 6.0f && !hasPlayedYouLostAudio)
                {
                    youLostAudio.Play();
                    hasPlayedYouLostAudio = true;
                }
                if (restartDelay < 0)
                {
                    SteamVR_LoadLevel.Begin("Level 1");
                }
            }
        }
    }

    private void StartPlaying()
    {
        SunRotate.shouldRotate = true;
        firstLauncher.StartLavaBombLauncher();
        secondLauncher.StartLavaBombLauncher();
    }

    public void PlayerWon()
    {
        Logger.Log("Player Won");
        birds.SetActive(true);
        firstLauncher.StopLavaBombLauncher();
        secondLauncher.StopLavaBombLauncher();
        SunRotate.shouldRotate = false;
        youWinAudio.Play();
    }

    public void PlayerLost()
    {
        Logger.Log("Player Lost");
        firstLauncher.StopLavaBombLauncher();
        secondLauncher.StopLavaBombLauncher();
        SunRotate.shouldRotate = false;
        didLose = true;
    }

}
