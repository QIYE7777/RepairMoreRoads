using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RepairMoreRoadsManager : MonoBehaviour
{
    public GameObject player;
    public static RepairMoreRoadsManager instance;
    public HoleBehavior hb;
    public float DeadPeople;

    private void Awake()
    {
        instance = this;
        DeadPeople = 0;
    }

    void Update()
    {
        GameOver();
    }

    void GameOver()
    {
        if (DeadPeople >= 10)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(0);
        }
    } 
}
