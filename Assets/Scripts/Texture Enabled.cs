using UnityEngine;

public class TextureEnabled : MonoBehaviour
{
    public Material[] materials;
    private float _isOn = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // for (int i = 0; i < materials.Length; i++)
        // {
        //     materials[i].SetFloat("_TextureEnabled", 1);
        // }
        //bumpMaterial.SetFloat("_Bump", _isOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            _isOn = 1 - _isOn;
            
            for (int i = 0; i < materials.Length; i++)
            {
                materials[i].SetFloat("_TextureEnabled", _isOn);
            }
        }
    }
}
