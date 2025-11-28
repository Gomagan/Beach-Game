using UnityEngine;

public class Shadowonoff : MonoBehaviour
{
    private Material _material;
    private float _isOn;
    void Start()
    {
        _material =  GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            _isOn = 1 - _isOn;
            _material.SetFloat("_Shadow", _isOn);
        }
    }
}
