using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDealDamage : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private int damage;

    // Update is called once per frame
    void Damage()
    {
        health.health -= damage;
    }
}
