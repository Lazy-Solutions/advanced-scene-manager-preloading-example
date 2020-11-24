using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{

    public string _tag = "Player";

    public UnityEvent OnEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_tag))
            OnEnter.Invoke();
    }

}
