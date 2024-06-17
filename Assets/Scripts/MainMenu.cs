
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Space Invaders");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
