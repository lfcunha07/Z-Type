using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private int damage;
    
    private GameObject castle;
    private Health health;
    
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        castle = GameObject.FindGameObjectWithTag("Player");
        health = castle.GetComponent<Health>();
    }

    // Update is called once per frame
    void Damage()
    {
        audioSource.Play();
        health.health -= damage;
    }
}
