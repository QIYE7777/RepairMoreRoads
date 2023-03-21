using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawn : MonoBehaviour
{
    public GameObject[] randomObjects;
    public Transform position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SpawnTriggerNew ()
    {
        int index = Random.Range(0, randomObjects.Length);
        var newBall = Instantiate(randomObjects[index], position);
        newBall.GetComponent<BallBehavior>().CloseKinematic();
    }
}
