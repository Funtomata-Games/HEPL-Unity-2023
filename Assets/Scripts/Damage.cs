using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] targetTags;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (targetTags.Contains(col.tag))
            Destroy(col.gameObject);
    }
}
