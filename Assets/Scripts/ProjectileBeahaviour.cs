using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBeahaviour : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int damage;
    [SerializeField] private bool isPlayer;

    private Rigidbody2D rgb2;
    private Animator anim;
    private Health health;

    // Start is called before the first frame update
    void Start()
    {
        rgb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer){
            rgb2.velocity = -transform.right*speed;
        }else{
            rgb2.velocity = transform.right*speed;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!isPlayer){
            if(col.gameObject.tag == "Player"){
                speed = 0;
                anim.SetBool("explode", true);
                health = col.gameObject.GetComponent<Health>();
                health.health -= damage;
            }
        }else{
            if(col.gameObject.tag == "Enemy"){
                speed = 0;
                anim.SetBool("explode", true);
                health = col.gameObject.GetComponent<Health>();
                health.health -= damage;
            }
        }
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
