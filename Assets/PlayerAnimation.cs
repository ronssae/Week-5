using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    int Horizontal, Vertical;

    private void Awake()
    {
        Horizontal = Animator.StringToHash("Horizontal");
        Vertical = Animator.StringToHash("Vertical");
    }
    public void UpdateAnimatorValues(float HorizontalMovement, float VerticalMovement)
    {
        if (PlayerManager.Instance.PlayerIsSprinting) {HorizontalMovement = 2;}
        PlayerManager.Instance.AnimatorPlayer.SetFloat(Horizontal, HorizontalMovement, 0.1f, Time.deltaTime);
        PlayerManager.Instance.AnimatorPlayer.SetFloat(Horizontal, HorizontalMovement, 0.1f, Time.deltaTime);
    }
}
