using DG.Tweening;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    public Rigidbody rd;
    public float speed;

    private void Awake()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rd.MovePosition(rd.position + Time.fixedDeltaTime *speed * Vector3.forward);
    }

   
}
