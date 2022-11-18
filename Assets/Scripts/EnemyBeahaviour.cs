using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeahaviour : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float speed;
    [SerializeField] private Transform castle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = castle.position - transform.position;
        Vector3 desiredUp = new Vector2(relativePos.y, -relativePos.x) * Mathf.Sign(-relativePos.x);
        
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, desiredUp);   
        transform.rotation = rotation;
    }
}
