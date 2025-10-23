using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorGradingScript : MonoBehaviour
{
    public Shader shader;
    public Material[] effects; // 0=Warm, 1=Cool, 2=BW
    public Material nothing;
    private int _currentIndex = 0;
    private bool _isColorGraded = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _currentIndex = (_currentIndex + 1) % effects.Length;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            _isColorGraded = !_isColorGraded;
        }
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        // Checks if color grading is on, and applies the effect
        Graphics.Blit(source, destination, _isColorGraded ? effects[_currentIndex] : nothing);
    }
}
