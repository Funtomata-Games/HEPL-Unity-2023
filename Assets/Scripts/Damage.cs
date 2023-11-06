using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] targetTags;
    public bool canKill;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (targetTags.Contains(col.tag))
        {
            KillOrDestroy(col.gameObject);
        }
    }

    private void KillOrDestroy(GameObject target)
    {
        if (canKill)
        {
            var deathCtrl = target.GetComponentInChildren<DeathController>();
            if (deathCtrl)
                deathCtrl.Kill();
            else
                Destroy(target);
        }
        else
        {
            Destroy(target);
        }
    }
}
