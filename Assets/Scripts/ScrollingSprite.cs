using UnityEngine;

public class ScrollingSprite : MonoBehaviour
{
    public Renderer renderer;
    [Header("Propriétés")]
    [SerializeField, Range(0f,1f)] private float speed;

    public float Speed
    {
        get => speed;
        set => speed = value;
    }


    private void Update()
    {
        renderer.material.mainTextureOffset += speed * Time.deltaTime * Vector2.right;
    }
}
