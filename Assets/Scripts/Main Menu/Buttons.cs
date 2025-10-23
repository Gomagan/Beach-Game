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
        // isGame = true;
        // FreeRoam();
    }
    
    public void FreeRoam()
    {
        SceneManager.LoadScene("Freeroam");
        // Menu.SetActive(false);
        // moveingCamera.SetActive(false);
        // playerCamera.SetActive(true);
        // player.SetActive(true);
    }
}
