using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Camera cam;
    public float speed;

    [SerializeField] InputActionReference moveInput;
    private void Awake()
    {
        cam = Camera.main;
    
    }
    private void Update()
    {
        Vector2 axis = moveInput.action.ReadValue<Vector2>();
        var screenPoint = cam.WorldToScreenPoint(transform.position);
        if (screenPoint.x <= 40) 
        {
            if (axis.x >= 0)
                axis.x = 0;
        }
        if (screenPoint.x >= Screen.width - 40) 
        {
            if (axis.x <= 0)
                axis.x = 0;
        }
        if (screenPoint.y <= 40)
        {
            if (axis.y >= 0)
                axis.y = 0;
        }
        if (screenPoint.y >= Screen.height) 
        {
            if (axis.y <= 0)
                axis.y = 0;
        }
        transform.Translate(axis*speed);
        if (axis != Vector2.zero)
        {
         //  Debugger.Messages.Add("x", transform.position.x.ToString());
         //   Debugger.Messages.Add("y", transform.position.y.ToString());
         // Debugger.LogOutput();
        }

    }
}