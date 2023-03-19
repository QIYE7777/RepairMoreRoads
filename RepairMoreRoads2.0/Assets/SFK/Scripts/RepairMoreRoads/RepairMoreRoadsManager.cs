using UnityEngine;
using System.Collections;

public class RepairMoreRoadsManager : MonoBehaviour
{
    public GameObject player;
    public static RepairMoreRoadsManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

}
