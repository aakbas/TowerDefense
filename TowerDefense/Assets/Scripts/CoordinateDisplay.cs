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
    private bool isGameStarted = false;

    void Awake()
    {
        coordinateLabel = GetComponent<TextMeshPro>();
        
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCordinates();
            UpdateObjectName();
        }
        else
        {
            if (!isGameStarted)
            {
                coordinateLabel.enabled = false;
                isGameStarted = true;
            }
        }
    }

    private void DisplayCordinates()
    {
        CalculateCoordinates();
        coordinateLabel.text = $"({ coordinateX},{coordinateY})";

    }

    private void CalculateCoordinates()
    {
        coordinateX = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinateY = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.y);
    }

    private void UpdateObjectName()
    {
        CalculateCoordinates();
        transform.parent.name = $"({ coordinateX},{coordinateY})";
    }

}
