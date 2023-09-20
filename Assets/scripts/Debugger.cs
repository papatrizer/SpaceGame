using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    public static Dictionary<string, string> Messages = new Dictionary<string, string>();

    public static void LogOutput()
    {
        foreach(string key in Messages.Keys)
        {
            Debug.Log(key + ": " + Messages[key]);
        }    
        Messages.Clear();
    }
}
