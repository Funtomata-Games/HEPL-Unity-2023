using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] damagableTags;
    public bool isKiller;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (damagableTags.Contains(col.tag))
            KillOrDestroy(col.gameObject);
    }

    private void KillOrDestroy(GameObject target)
    {
        if (!isKiller)
        {
            Destroy(target);
            return;
        }

        var deathCtrl = target.GetComponent<DeathController>();
        if (deathCtrl)
        {
            deathCtrl.Kill();
        }
        else
        {
            Destroy(target);
        }
    }
}
