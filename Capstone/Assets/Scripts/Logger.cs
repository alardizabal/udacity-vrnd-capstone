using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{

    public static bool isDebugging = true;

    public static void Log(string message)
    {
        if (!isDebugging)
        {
            return;
        }
        else
        {
            Debug.Log(message);
        }
    }

    public static void Log(int message)
    {
        if (!isDebugging)
        {
            return;
        }
        else
        {
            Debug.Log(message);
        }
    }
}