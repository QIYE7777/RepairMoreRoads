using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RepairMoreRoadsManager : MonoBehaviour
{
    public GameObject player;
    public static RepairMoreRoadsManager instance;
    public float deadPeople;
    public float delayGameOverTime = 3f;
    public Canvas gameOverImagine;
    bool IsShowed = false;

    private void Awake()
    {
        instance = this;
        deadPeople = 0;
        IsShowed = false;
    }

    void Update()
    {
        if (deadPeople >= 10 && IsShowed == false )
        {
            gameOverImagine.enabled = !gameOverImagine.enabled;
            StartCoroutine ( GameOver());
            IsShowed = true; ;
        }
    }

    public IEnumerator GameOver()
    {
        
            yield return new WaitForSeconds (delayGameOverTime);
            Debug.Log("GameOver");
            SceneManager.LoadScene(0);

    } 
}
