using System;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float delay;

    private void Start()
    {
        Invoke(nameof(AutoDestruction), delay);
    }

    public void AutoDestruction()
    {
        Destroy(gameObject);
    }
}
