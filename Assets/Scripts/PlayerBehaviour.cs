using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float currentAngle = 0f;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Health health;


    void Update()
    {
        if(health.health > 0){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentAngle);
            if(Input.GetKey(KeyCode.A)){
                currentAngle += 1f;
            }else if(Input.GetKey(KeyCode.D)){
                currentAngle -= 1f;
            }

            if(Input.GetKeyDown(KeyCode.P)){
                Instantiate(projectile, transform.position, Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z+90));
            }
        }
    }
}
