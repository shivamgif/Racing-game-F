using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Waypoint : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    public PointsScore pointScore;
    int index = 0;

    public bool disableInGame;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
            if(!disableInGame)
        {
            Transform[] tem = GetComponentsInChildren<Transform>();


            if (tem.Length > 0)
            {
                waypoints.Clear();
                index = 0;
                foreach (Transform t in tem)
                {
                    if (t != transform)
                    {

                        t.name = "Way_" + index.ToString();
                        waypoints.Add(t);
                        index++;
                    }

                }
            }
            if (waypoints.Count > 0)
            {
                Gizmos.color = Color.green;
                foreach (Transform t in waypoints)
                {
                    Gizmos.DrawSphere(t.position, 1f);
                }

                Gizmos.color = Color.red;

                for (int a = 0; a < waypoints.Count - 1; a++)
                {
                    Gizmos.DrawLine(waypoints[a].position, waypoints[a + 1].position);

                }
            }
            }
        }


        


    }
    


