using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DelayEvent : MonoBehaviour
{
    [Min(0)] public float delayTime = 1;
    public bool repeat = false;

    [Space]
    public UnityEvent DelayedEvent;

    // Start is called before the first frame update
    void Start()
    {
        StartDelay();
    }

    private void StartDelay()
    {
        StartCoroutine(DelayCR());
    }

    private IEnumerator DelayCR()
    {
        yield return new WaitForSeconds(delayTime);
        DelayedEvent?.Invoke();

        if (repeat)
            StartCoroutine(DelayCR());
    }
}
