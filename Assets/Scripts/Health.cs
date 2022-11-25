using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public float health = 100f;
    private GameObject score;
    private TextMeshProUGUI scoreText;
    private ScoreCount scoreCount;

    [SerializeField] private GameObject gameOverScreen;

    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score");
        scoreText = score.GetComponent<TextMeshProUGUI>();
        scoreCount = score.GetComponent<ScoreCount>();
    }

    void Update()
    {
        if(health <= 0){
            if(gameObject.tag == "Enemy"){
                int count = scoreCount.score + 100;
                scoreText.text = "SCORE: " + count;
                scoreCount.IncreseScore();
                Destroy(gameObject);
            }else{
                gameOverScreen.SetActive(true);
            }
        }
    }
}
