using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI gameOverText;
    
    public GameObject checkList;
    public GameObject ball, goldBar, crab, coin;

    private int _foundObjects = 0;

    private float _timer = 30;

    public TextMeshProUGUI timeText;
    
    void Start()
    {
        
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        timeText.text = ((int)_timer).ToString();
        if (_timer <= 0|| _foundObjects == 4)
        {
            gameOverScreen.SetActive(true);
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (_foundObjects == 4)
            {
                gameOverText.text = "You Won!";
            }
            else
            {
                gameOverText.text = "You Lost!";
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (ball.activeSelf == false)
            {
                ball.SetActive(true);
                _foundObjects++;
            }
            
        }

        if (other.CompareTag("Bar"))
        {
            if (goldBar.activeSelf == false)
            {
                goldBar.SetActive(true);
                _foundObjects++;
            }
        }

        if (other.CompareTag("Crab"))
        {
            if (crab.activeSelf == false)
            {
                crab.SetActive(true);
                _foundObjects++;
            }
        }

        if (other.CompareTag("Coin"))
        {
            if (coin.activeSelf == false)
            {
                coin.SetActive(true);
                _foundObjects++;
            }
        }
    }
}
