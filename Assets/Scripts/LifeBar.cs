using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Health life;
    [SerializeField] private Image lifeBar;

    private float lifeSize;

    void Start()
    {
        lifeSize = life.health * 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        lifeSize = life.health * 0.01f;
        lifeBar.fillAmount = lifeSize;
    }
}
