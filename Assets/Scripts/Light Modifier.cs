using UnityEngine;

public class LightModifier : MonoBehaviour
{
    public Material[] materials;
    private Renderer _rend;
    private int _currentIndex = 0;
    void Start()
    {
        _rend = GetComponent<Renderer>();
        _rend.material = materials[_currentIndex];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _currentIndex = (_currentIndex + 1) % materials.Length;
            _rend.material = materials[_currentIndex];
        }
    }
}
