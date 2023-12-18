using System;
using UnityEngine;

public class TextureMovement : MonoBehaviour
{
    public Renderer renderer;
    public Vector2 movementSpeed;
    private Material _material;

    private void Awake()
    {
        _material = renderer.material;
    }

    private void Update()
    {
        _material.mainTextureOffset += movementSpeed * Time.deltaTime;
    }
}
