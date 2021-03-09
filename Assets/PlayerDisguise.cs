using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisguise : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite[] sprites;
    
    public bool canDisguise;
    public bool hasDisguise = false;

    [SerializeField] private GameObject box, circle;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canDisguise && Input.GetKeyDown(KeyCode.Space))
        {
            hasDisguise = true;
            _spriteRenderer.sprite = sprites[1];
            box.SetActive(true);
            circle.SetActive(false);

        }
        
        if (hasDisguise && Input.GetKeyDown(KeyCode.X))
        {
            hasDisguise = false;
            _spriteRenderer.sprite = sprites[0];
            box.SetActive(false);
            circle.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Kill and disguise");
            canDisguise = true;
            if (hasDisguise)
            {
                canDisguise = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            canDisguise = false;
        }
    }
}
