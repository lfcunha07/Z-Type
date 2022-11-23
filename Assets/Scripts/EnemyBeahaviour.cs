using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeahaviour : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float speed;
    [SerializeField] private Transform castle;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rg2;
    [SerializeField] private GameObject projectile;

    private bool isColliding = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = castle.position - transform.position;
        Vector3 desiredUp = new Vector3(relativePos.x, relativePos.y, relativePos.z) * Mathf.Sign(relativePos.z);
        rg2.velocity = relativePos*speed;
        
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, -desiredUp);   
        transform.rotation = rotation;
        
        float distance = relativePos.magnitude;
        if(distance <= range || isColliding){
            speed = 0;
            anim.SetBool("inRange", true);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            isColliding = true;
        }
    }

    void Shoot()
    {
        Instantiate(projectile, transform.position, Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z-90f));
    }
}
