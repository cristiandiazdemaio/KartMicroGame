using UnityEngine;
using UnityEngine.Events;

public class ActionTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent eventToactivate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eventToactivate?.Invoke();
        }
    }
}
