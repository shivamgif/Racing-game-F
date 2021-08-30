using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Obstacle : MonoBehaviour
{
    public PointsScore pointsScore;
    public Text txt;

    private void Start()
    {
        txt.enabled = false;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "car1")
        {
            pointsScore.DecreaseObstaclePoints();
            Message();
        }
    }


    void Message()
    {
        txt.enabled = true;
        txt.text = "You hit an obstacle";
        txt.color = Color.red;
        Invoke("TextToFalse", 1);
    }

    void TextToFalse()
    {
        txt.enabled = false;
    }
}
