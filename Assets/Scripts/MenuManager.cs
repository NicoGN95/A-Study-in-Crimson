using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string _level1;

    public void Play()
    {
        SceneManager.LoadScene(_level1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
