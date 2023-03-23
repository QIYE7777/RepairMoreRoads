using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleShooter : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force;
    public SpawnerPosition sp;
    public JudgeColor changeHasState;

    private void FixedUpdate()
    {
        //rigidbody.AddForce(new Vector3 (2, 3, 5) * force,ForceMode.Impulse );
    }
    
    public void Shoot()
    {
        rigidbody.AddForce(Vector3.forward  * force, ForceMode.Impulse);
        //changeHasState.differColorHas = false;
        //Debug.Log(changeHasState.differColorHas);
    }

    public void SpawnBall()
    {
        sp.TriggerSpawn();
    }
}
