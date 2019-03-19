using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Clicker");
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
