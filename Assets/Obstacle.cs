using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public PointsScore pointsScore;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "car1")
        {
            pointsScore.DecreaseObstaclePoints();

        }
    }
}
