using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeper : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        score++;
        print("score:" + score);
    }
}
