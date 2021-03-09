using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingAnim : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = FindObjectOfType<PlayerMovement>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("run", _playerMovement.isMoving);

        _spriteRenderer.flipX = _playerMovement.isFlipped;
    }
}
