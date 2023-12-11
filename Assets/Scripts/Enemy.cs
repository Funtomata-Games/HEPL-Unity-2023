using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.score++;
        print(GameManager.score);
    }
}
