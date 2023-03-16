using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public SpawnerBase spawnerBase;
    public JudgeColor judgeColor;
    void Start()
    {
        spawnerBase = GetComponent<SpawnerBase>();
        judgeColor = GetComponent<JudgeColor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hole" && judgeColor.sameColor == true )
        {
            spawnerBase.manageImpulse = true;
            Debug.Log("destroy");
            Destroy(gameObject );
        }
    }

}
