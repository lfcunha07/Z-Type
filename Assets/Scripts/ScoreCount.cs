using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public int score = 0;
    public void IncreseScore()
    {
        score += 100;
    }
}
