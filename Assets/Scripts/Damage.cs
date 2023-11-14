using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] damageableTags;
    public bool canKill;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (damageableTags.Contains(col.tag))
        {
            KillOrDestroy(col.gameObject);
        }
    }

    private void KillOrDestroy(GameObject target)
    {
        if (!canKill)
            Destroy(gameObject);
        else
        {
            var deathMgr = target.GetComponentInChildren<DeathManager>();
            if (!deathMgr) Destroy(gameObject);
            else deathMgr.Kill();
        }
    }
}
