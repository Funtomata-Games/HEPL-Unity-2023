using System;
using UnityEngine;

public class SnakeBehaviour : MonoBehaviour
{
   public bool isSnake;
   public Animator animator;
   private static readonly int IsSnake = Animator.StringToHash("isSnake");

   private void Start()
   {
      animator.SetBool(IsSnake, isSnake);
   }
}
