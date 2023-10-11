using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //define tags we can damage
    public string[] damageTags;

    //detect if the trigger is entered
    private void OnTriggerEnter2D(Collider2D other)
    {
        //checks the tag of the triggering object
        if (damageTags.Contains(other.tag))
        {
            //destroys it
            Destroy(other.gameObject);
        }
    }
}
