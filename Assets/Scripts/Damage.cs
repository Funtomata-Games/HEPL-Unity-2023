using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] targetTags;
    public bool killTarget;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (targetTags.Contains(col.tag))
            KillOrDestroy(col.gameObject);
    }

    private void KillOrDestroy(GameObject target)
    {
        if (killTarget)
        {
            var deathMgr = target.GetComponentInChildren<DeathManager>();
            if (deathMgr)
                deathMgr.Kill();
            else Destroy(target);
        }
        else Destroy(target);
    }
}