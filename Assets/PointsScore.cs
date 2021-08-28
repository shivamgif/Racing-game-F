using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScore : MonoBehaviour
{
    public Text txt;

    private int minPoints = 1;
    private int maxPoints = 100;

    private static int points = 0;

    float elapsed = 0;



    public void IncreaseScore()
    {
        if (points >= maxPoints)
        {
            points = maxPoints;
            txt.text = "Points:" + points;
            Debug.Log("Win");
           
        }

        if (points < 100) 
            points ++;
          Debug.Log(points);
          txt.text = "Points:" + points;
        
    }

    public void DecreaseScore()
    {
        points--;
        Debug.Log(" Losing" + points);
        txt.text = "Points:" + points;
        if (points <= minPoints)
        {
            points = minPoints-1;
            txt.text = "Points:" + points;
            Debug.Log("Game Over");
        }
        
       
    }

}
