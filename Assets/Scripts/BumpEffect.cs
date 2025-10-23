using UnityEngine;

public class BumpEffect : MonoBehaviour
{
    public Material bumpMaterial;

    private bool _isOn = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bumpMaterial.EnableKeyword("_Bump?_ON");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("R");
            if (_isOn)
            {
                bumpMaterial.EnableKeyword("_Bump?_OFF");
                _isOn = false;
            }
            else
            {
                bumpMaterial.EnableKeyword("_Bump?_ON");
                _isOn = false;
            }
            
        }
    }
}
