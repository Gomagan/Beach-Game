using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    LayerMask _layerMask;
    void Start()
    {  
        _layerMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        
    }
}
