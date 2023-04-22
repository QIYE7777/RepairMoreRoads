using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public void StartGame()
    {
        StartCoroutine(Delay());
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("button");
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
