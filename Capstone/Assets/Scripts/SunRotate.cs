using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{

    public GameObject directionalLight;
    public GameStateManager gameManager;
    private float timeLeft = 60.0f;
    public static bool shouldRotate = false;

    void FixedUpdate()
    {
        if (shouldRotate)
        {
            directionalLight.transform.Rotate(0f, Time.deltaTime * 2.0f, 0f);
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                gameManager.PlayerWon();
            }
        }
    }
}
