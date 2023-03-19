using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanBall : MonoBehaviour
{
    public SpawnerPosition sp;

    public void Spawn()
    {
        sp.TriggerSpawn();
        Debug.Log("spawn new ball");
    }
}
