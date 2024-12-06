using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string isWalking = "IsWalking";

    private Animator playerAnimator;

    [SerializeField] private Player player;

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        playerAnimator.SetBool(isWalking, player.IsWalking());
    }
}
