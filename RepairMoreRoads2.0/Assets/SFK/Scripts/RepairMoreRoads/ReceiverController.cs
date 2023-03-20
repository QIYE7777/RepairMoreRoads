using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverController : MonoBehaviour
{
    public ColorEnum colorEnum;
    public AudioSource siu;

    private void Awake()
    {
        colorEnum = GetComponent<ColorEnum>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            if (other.GetComponent<ColorEnum>().isFromHole == true)
            {
                Rigidbody playerRd = RepairMoreRoadsManager.instance.player.GetComponent<Rigidbody >();
                Rigidbody rd = other.GetComponent<Rigidbody>();
                siu.Play();
                rd.MovePosition(playerRd.position + new Vector3 (0f,2.5f,6f));
            }
        }

    }
}