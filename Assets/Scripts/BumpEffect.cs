using UnityEngine;

public class BumpEffect : MonoBehaviour
{
    public Material bumpMaterial;

    private float _isOn = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bumpMaterial.SetFloat("_Bump", _isOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _isOn = 1 - _isOn;
            bumpMaterial.SetFloat("_Bump", _isOn);
        }
    }
}
