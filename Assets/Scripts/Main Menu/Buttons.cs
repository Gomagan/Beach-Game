using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject moveingCamera;
    public GameObject playerCamera;
    public GameObject player;
    public GameObject Menu;

    public bool isGame = false;

    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }
    
    public void FreeRoam()
    {
        SceneManager.LoadScene("Freeroam");
    }
}
