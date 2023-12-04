using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    public float maxDistance;
    public Color enemyColor =  Color.red;
    public Color playerColor = Color.green;

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector2.right * maxDistance, Color.magenta);
        var raycastHit = Physics2D.Raycast(transform.position, Vector2.right, maxDistance);
        if (!raycastHit) return;
        var color = Color.white;
        if (raycastHit.rigidbody.tag == "Player")
            color = playerColor;
        if (raycastHit.rigidbody.tag == "Enemy")
            color = enemyColor;
        raycastHit.rigidbody.gameObject.GetComponent<SpriteRenderer>().color = color;
    }
    
}
