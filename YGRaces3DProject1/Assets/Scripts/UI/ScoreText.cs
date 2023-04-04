using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI scoreText;

    private void ChangeText(int newScore){
        scoreText.text = newScore.ToString();
    }

    private void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
        Car.OnScoreChange += ChangeText;
    }

    private void OnDestroy() {
        Car.OnScoreChange -= ChangeText;
    }
}
