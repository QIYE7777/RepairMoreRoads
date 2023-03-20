using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleShooter : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force;
    public SpawnerPosition sp;

    private void FixedUpdate()
    {
        //rigidbody.AddForce(new Vector3 (2, 3, 5) * force,ForceMode.Impulse );
    }
    
    public void Shoot()
    {
        rigidbody.AddForce(Vector3.forward  * force, ForceMode.Impulse);
    }

    public void SpawnBall()
    {
        sp.TriggerSpawn();
    }
}
