using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skor : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public int score;
    private void Start()
    {
        score = 0;
    }
    public void updateScore() {
        score++;
        scoretext.text=score.ToString();
    }
}
