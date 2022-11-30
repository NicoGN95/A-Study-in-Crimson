using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    [SerializeField] private string _mainMenu;

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
