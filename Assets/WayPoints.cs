using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;


    public PointsScore pointScore;
    private bool isCollided;
    int layermask = 1 << 8;

    public GameObject line;

    public LineRenderer rendererLine;
    public List<Transform> Points = new List<Transform>();

    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color green = Color.green;
    public Color yellow = Color.yellow;
    public Color white = Color.white;

    public GameObject carBody;
    // Start is called before the first frame update
    int index = 0;
    private void Awake()
    {
        
    }
    void Start()
    {
        rendererLine = line.GetComponent<LineRenderer>();
        Renderer renderedBody = carBody.GetComponent<MeshRenderer>();
        
        Color bodyColor = renderedBody.material.color;
        rendererLine.positionCount = 3;

        
     
    }

    // Update is called once per frame
    void Update()
    {

        cube1.GetComponent<LineRenderer>().SetPosition(0, cube1.transform.position);
        cube1.GetComponent<LineRenderer>().SetPosition(1, cube2.transform.position);
        cube2.GetComponent<LineRenderer>().SetPosition(0, cube2.transform.position);
        cube2.GetComponent<LineRenderer>().SetPosition(1, cube3.transform.position);
        cube3.GetComponent<LineRenderer>().SetPosition(0, cube3.transform.position);
        cube3.GetComponent<LineRenderer>().SetPosition(1, cube4.transform.position);
        cube4.GetComponent<LineRenderer>().SetPosition(0, cube4.transform.position);
        cube4.GetComponent<LineRenderer>().SetPosition(1, cube5.transform.position);
        cube5.GetComponent<LineRenderer>().SetPosition(0, cube5.transform.position);
        cube5.GetComponent<LineRenderer>().SetPosition(1, cube6.transform.position);
        cube6.GetComponent<LineRenderer>().SetPosition(0, cube6.transform.position);
        cube6.GetComponent<LineRenderer>().SetPosition(1, cube7.transform.position);
        cube7.GetComponent<LineRenderer>().SetPosition(0, cube7.transform.position);
        cube7.GetComponent<LineRenderer>().SetPosition(1, cube8.transform.position);
        cube8.GetComponent<LineRenderer>().SetPosition(0, cube8.transform.position);
        cube8.GetComponent<LineRenderer>().SetPosition(1, cube1.transform.position);



        cube1.GetComponent<LineRenderer>().startColor =
        Color.green;
        cube1.GetComponent<LineRenderer>().endColor =
        Color.green;
        cube2.GetComponent<LineRenderer>().startColor =
        Color.green;
        cube2.GetComponent<LineRenderer>().endColor =
        Color.green;

        if (Physics.Linecast(cube1.transform.position, cube2.transform.position, layermask))
        {
            Debug.Log("blocked");
            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube1.transform.position, cube2.transform.position, Color.white, 2.5f);

        }
        else
        {
            pointScore.DecreaseScore();
        }

        if (isCollided == false)
        {
            pointScore.DecreaseScore();
        }

        if (Physics.Linecast(cube2.transform.position, cube3.transform.position, layermask))
        {
            
            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube2.transform.position, cube3.transform.position, Color.white, 2.5f);

        }
       

        if (Physics.Linecast(cube3.transform.position, cube4.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube3.transform.position, cube4.transform.position, Color.white, 2.5f);

        }

        if (Physics.Linecast(cube4.transform.position, cube5.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube4.transform.position, cube5.transform.position, Color.white, 2.5f);

        }

        if (Physics.Linecast(cube5.transform.position, cube6.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube5.transform.position, cube6.transform.position, Color.white, 2.5f);

        }

        if (Physics.Linecast(cube6.transform.position, cube7.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube6.transform.position, cube7.transform.position, Color.white, 2.5f);

        }

        if (Physics.Linecast(cube7.transform.position, cube8.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube7.transform.position, cube8.transform.position, Color.white, 2.5f);

        }

        if (Physics.Linecast(cube8.transform.position, cube1.transform.position, layermask))
        {

            isCollided = true;
            pointScore.IncreaseScore();
            Debug.DrawLine(cube8.transform.position, cube1.transform.position, Color.white, 2.5f);

        }

       
    }
}
