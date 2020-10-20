using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;


    public void UpdateScoreDisplay(int currentScore)
    {
        pointsText.text = "Point: " + currentScore.ToString();
    }
}