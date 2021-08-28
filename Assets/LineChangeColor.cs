using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LineChangeColor : MonoBehaviour
{

    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color green = Color.green;
    public Color yellow = Color.yellow;
    public Color white = Color.white;

    public GameObject carBody;
    public GameObject line;

    public LineRenderer rendererLine;


    private void Start()
    {
        Renderer renderedBody = carBody.GetComponent<MeshRenderer>();
        Color bodyColor = renderedBody.material.color;
        Debug.Log("Item color is " + bodyColor);
        LineRenderer rendererLine = line.GetComponent<LineRenderer>();
        rendererLine.startColor = bodyColor;
        rendererLine.endColor = bodyColor;//colorGradient.SetKeys(new GradientColorKey[] { new GradientColorKey(bodyColor, 1.0f) },
                                          //new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 1.0f) });


    }
 
}
