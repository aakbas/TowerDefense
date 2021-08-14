using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


[ExecuteAlways]
public class CoordinateDisplay : MonoBehaviour
{
    private TextMeshPro coordinateLabel;
    private int coordinateX;
    private int coordinateY;

    void Awake()
    {
        coordinateLabel = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCordinates();            
        }
    }

    private void DisplayCordinates()
    {
        coordinateX = Mathf.RoundToInt(transform.parent.position.x);
        coordinateY = Mathf.RoundToInt(transform.parent.position.z);
        coordinateLabel.text = $"({ coordinateX},{coordinateY})";
        

    }

}
