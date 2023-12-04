using System;
using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] damageableTags;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (damageableTags.Contains(col.tag))
            Destroy(col.gameObject);
    }
}
