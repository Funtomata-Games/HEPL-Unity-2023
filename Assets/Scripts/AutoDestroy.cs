using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float delay;

    private void Start()
    {
        Invoke(nameof(OnTimeout), delay);
    }

    private void OnTimeout()
    {
        Destroy(gameObject);
    }
}