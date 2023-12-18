using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float delay;

    private void Start()
    {
        Invoke(nameof(AutoDestruction), delay);
    }

    private void AutoDestruction()
    {
        Destroy(gameObject);
    }
    

}
