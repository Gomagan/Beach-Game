using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorGradingScript : MonoBehaviour
{
    // This gets the shader
    public Shader shader;
    
    // An array to get the materials for the color grading
    public Material[] effects; // 0=Warm, 1=Cool, 2=BW
    
    // This material sets the contribution to 0. This is the default material for when colorcorrection is not applied
    public Material nothing;
    
    // This is the index that affects which colorcorrection is currently applied
    private int _currentIndex = 0;
    
    // A check to see if the colorcorrection is on or off
    private bool _isColorGraded = false;
    
    
    // This runs each frame, and the goal is to check if these buttons are pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // This increases the currentIndex number by 1 and if it is max, it will go back to 0
            _currentIndex = (_currentIndex + 1) % effects.Length;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            // This turns color correction on and off
            _isColorGraded = !_isColorGraded;
        }
    }
    
    // This is the camera renderer
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        // Checks if color grading is on, and applies the effect if it's on. So if colorgraded (apply the effect) else (apply the nothing effect)
        Graphics.Blit(source, destination, _isColorGraded ? effects[_currentIndex] : nothing);
    }
}
