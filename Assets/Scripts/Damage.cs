using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] damagableTags;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (damagableTags.Contains(col.tag))
            Destroy(col.gameObject);
    }
}
