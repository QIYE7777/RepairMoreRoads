using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public RepairMoreRoadsManager manager;

    void Update()
    {
        //scoreText.text = player.position.z .ToString ("0");
        float dead = 10 - manager.deadPeople; 
        scoreText.text =  dead.ToString();
    }
}
