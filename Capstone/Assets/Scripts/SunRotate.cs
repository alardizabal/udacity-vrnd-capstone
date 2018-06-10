using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{

    public GameObject directionalLight;

    void FixedUpdate()
    {
        directionalLight.transform.Rotate(0f, Time.deltaTime * 2.0f, 0f);
    }
}
