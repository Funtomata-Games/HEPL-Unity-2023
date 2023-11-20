using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(direction.normalized * (speed * Time.deltaTime), Space.World);
    }
}
