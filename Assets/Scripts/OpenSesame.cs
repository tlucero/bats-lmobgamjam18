using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;

    [SerializeField] private GameObject gate;
    
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
            gate.SetActive(false);
            _playerDisguise.canRevert = true;
        }
    }
}
