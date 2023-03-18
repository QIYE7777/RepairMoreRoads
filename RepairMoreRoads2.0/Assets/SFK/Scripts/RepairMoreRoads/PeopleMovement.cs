using DG.Tweening;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    public CharacterController cc;
    public Vector3 movement { get; private set; }
    public float speed;
    public float h;
    public float v;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move(h,v );
    }

    void Move(float h, float v)
    {
        movement = new Vector3(h, 0f, v);
        //movement = movement.normalized * speed * Time.deltaTime;
        var realSpeed = speed;
        cc.SimpleMove(movement.normalized * realSpeed);
    }
}
