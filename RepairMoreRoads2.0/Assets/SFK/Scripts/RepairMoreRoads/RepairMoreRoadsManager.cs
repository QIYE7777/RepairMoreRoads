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
    public Canvas youWin;
    bool isShowed = false;
    bool youWinIsShowed = false;
    public MySpawn mySpawn;
    public ParticleSystem[] fireWorks;
    public AudioSource win;
    public AudioSource cheer;

    private void Awake()
    {
        instance = this;
        deadPeople = 0;
        isShowed = false;
        youWinIsShowed = false;
    }

    void Update()
    {
        if (deadPeople >= 10 && isShowed == false )
        {
            gameOverImagine.enabled = !gameOverImagine.enabled;
            player.GetComponent<PeopleMovement>().enabled = !player.GetComponent<PeopleMovement>().enabled;
            StartCoroutine ( GameOver());
            isShowed = true; ;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(GameOver());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mySpawn.SpawnTriggerNew();
        }
    }

    public IEnumerator GameOver()
    {
        
            yield return new WaitForSeconds (delayGameOverTime);
            Debug.Log("GameOver");
            SceneManager.LoadScene(0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (youWinIsShowed == false)
            {
                youWin.enabled = !youWin.enabled;
                win.Play();
                cheer.Play();
                //fireWorks []
                foreach (var f in fireWorks)
                {
                    f.Play();
                }
                player.GetComponent<PeopleMovement>().enabled = !player.GetComponent<PeopleMovement>().enabled;
                StartCoroutine(GameOver());
                youWinIsShowed = true;
            }
        }
    }
}
