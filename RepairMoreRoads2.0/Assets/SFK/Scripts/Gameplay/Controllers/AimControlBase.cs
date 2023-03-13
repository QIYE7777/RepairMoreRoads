using UnityEngine;

[RequireComponent(typeof(TennisActions))]
public abstract class AimControlBase : MonoBehaviour
{
    public string ID = "Player";
    public Animator animator;
    public TennisActions actions;

    [HideInInspector]
    public Transform targetBall;
    protected Collider m_racketCollider;
    protected Vector3 direction;

    private void Reset()
    {
        ID = "Player_" + gameObject.name;
        animator = GetComponent<Animator>();
        actions= GetComponent<TennisActions>();
    }

    private void Start()
    {
        if (ID == string.Empty)
        {
            ID = gameObject.name;
            Debug.LogWarning("Using GameObject name as ID, please set the ID variable");
        }

        m_racketCollider = GetComponent<Collider>();
    }

    protected void FindBall()
    {
        GameObject b = GameObject.FindGameObjectWithTag("Ball");
        if (b)
            targetBall = b.transform;
    }
}
