using UnityEngine;

public class AimControlInputs : AimControlBase
{
    //public enum MouseButton
    //{
    //    Left, //0
    //    Right, //1
    //    Middle, //2
    //    Forward, //3
    //    Back, //4
    //}


    public Transform aimTransform;

    [Header("Aim")]
    public string aimSidewaysAxis = "Mouse X";
    [Tooltip("How fast the input axis influences the aim position")]
    [Min(0)] public float sidewaysMultiplier = 1;
    public string aimLengthwiseAxis = "Mouse Y";
    [Tooltip("How fast the input axis influences the aim position")]
    [Min(0)] public float legthwiseMultiplier = 1;

    [Tooltip("Instead of setting the aim position directly, the axis add and offset to the aim position")]
    public bool incrementPosition = true;
    public bool localPosition = false;
    public bool hideCursor = true;

    [Header("Swing")]
    //public MouseButton mouseButtonSwing = MouseButton.Left;
    public string swingInput = "Fire1";

    [Header("Lift")]
    //public MouseButton mouseButtonLift = MouseButton.Right;
    public string liftInput = "Fire2";

    [Space]
    public bool aimLimits = true;
    public Vector3 minAim = Vector3.zero;
    public Vector3 maxAim = Vector3.zero;

    private void OnDrawGizmosSelected()
    {
        if (aimLimits)
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            Gizmos.DrawCube((minAim + maxAim) * 0.5f, maxAim - minAim + Vector3.up * 0.5f);
        }
    }

    private void Start()
    {

        if (hideCursor)
            Cursor.lockState = CursorLockMode.Locked;
    }

    protected void Update()
    {
        if (targetBall == null)
            FindBall();

        UpdateAim();

        if (Input.GetButton(swingInput))
            actions.Swing();
        if (Input.GetButton(liftInput))
            actions.Lift();
    }


    public void UpdateAim()
    {
        Vector3 currentPosition = transform.position;

        Vector3 input = Input.GetAxis(aimSidewaysAxis) * sidewaysMultiplier * Vector3.right + (Input.GetAxis(aimLengthwiseAxis) * legthwiseMultiplier * Vector3.forward);

        if (incrementPosition)
            input += actions.AimPosition;

        Vector3 finalPosition = input + (localPosition ? currentPosition : Vector3.zero);

        if (aimLimits)
        {
            finalPosition = new Vector3(Mathf.Clamp(finalPosition.x, minAim.x, maxAim.x),
                                        Mathf.Clamp(finalPosition.y, minAim.y, maxAim.y),
                                        Mathf.Clamp(finalPosition.z, minAim.z, maxAim.z));
        }


        actions.AimPosition = finalPosition;

        aimTransform.gameObject.SetActive(true);
        aimTransform.position = finalPosition;

        Debug.DrawRay(currentPosition + Vector3.up, finalPosition - currentPosition, Color.yellow);

        animator.SetFloat("Direction", (targetBall.position - finalPosition).x);
    }
}
