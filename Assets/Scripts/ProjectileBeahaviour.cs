using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBeahaviour : MonoBehaviour
{
    [SerializeField] private int speed;

    private Rigidbody2D rgb2;
    // Start is called before the first frame update
    void Start()
    {
        rgb2 = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgb2.velocity = transform.forward*speed;
    }
}
