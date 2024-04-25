using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text screenScore;
    
    [ContextMenu("Add Score")]
    public void AddScore()
    {
        score++;
        screenScore.text = score.ToString();
    }
    
}
