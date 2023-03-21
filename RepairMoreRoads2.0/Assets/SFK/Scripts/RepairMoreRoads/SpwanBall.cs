using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanBall : MonoBehaviour
{
    public SpawnerPosition sp;
    public MySpawn ms;

    public void Spawn()
    {
        ms.SpawnTriggerNew ();
        Debug.Log("spawn new ball");
    }
}
