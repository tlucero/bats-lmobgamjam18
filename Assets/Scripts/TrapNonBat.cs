using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapNonBat : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerDisguise = FindObjectOfType<PlayerDisguise>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && _playerDisguise.hasDisguise)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            return;
        }
    }
}
