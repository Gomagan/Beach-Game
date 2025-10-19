using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public Buttons buttons;

    public GameObject checkList;
    void Start()
    {
        if (buttons.isGame == true)
        {
            checkList.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
