using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoSceneManager : MonoBehaviour
{
    [SerializeField] private string _credits;


    private void Update()
    {
        EndDemo();
    }

    private void EndDemo()
    {
        StartCoroutine(StartDelay());

    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(_credits);
    }
}
