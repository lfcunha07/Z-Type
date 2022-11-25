using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    private float frequency = 0f;
    private float min = 15f;
    private float max = 18f;
    private bool isSpawning;
    
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;

    // Update is called once per frame
    void Update()
    {
        if(frequency != Mathf.Floor(Time.timeSinceLevelLoad/30)){
            frequency += Mathf.Floor(Time.timeSinceLevelLoad/30);
        }
        if(frequency >= 14f){
            frequency = 14f;
        }
        float num = Random.Range(min - frequency, max - frequency);
        if(!isSpawning){
            StartCoroutine(SpawnTimer(num));
            isSpawning = true;
        }
    }

    IEnumerator SpawnTimer(float num)
    {
        yield return new WaitForSeconds(num);
        int var = Random.Range(0,2);
        if(var == 0){
            Instantiate(enemy1, transform);
        }else{
            Instantiate(enemy2, transform);
        }
        isSpawning = false;
    }
}
