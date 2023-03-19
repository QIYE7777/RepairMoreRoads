using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RepairMoreRoadsManager : MonoBehaviour
{
    public GameObject player;
    public static RepairMoreRoadsManager instance;
    public float DeadPeople;
    public float DelayGameOverTime = 3f;

    private void Awake()
    {
        instance = this;
        DeadPeople = 0;
    }

    void Update()
    {
        GameOver();
    }

    public IEnumerator GameOver()
    {
        if (DeadPeople >= 10)
        {
            yield return new WaitForSeconds (DelayGameOverTime);
            Debug.Log("GameOver");
            SceneManager.LoadScene(0);
        }
    } 
}
