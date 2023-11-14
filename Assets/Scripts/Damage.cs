using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
   public string[] damageableTags;
   public bool killTarget;

   private void OnTriggerEnter2D(Collider2D col)
   {
      if (damageableTags.Contains(col.tag))
         KillOrDestroy(col.gameObject);
   }

   private void KillOrDestroy(GameObject target)
   {
      if (!killTarget) Destroy(target);
      else
      {
         var deathCtrl = target.GetComponentInChildren<DeathController>();
         if (!deathCtrl) Destroy(target);
         else deathCtrl.Kill();
      }
   }
}
