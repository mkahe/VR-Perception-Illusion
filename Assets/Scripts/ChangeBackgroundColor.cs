using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundColor : MonoBehaviour
{
    private Renderer cubeRenderer;
    private Renderer backgroundRenderer;
    
    public GameObject backgroundWall;
    public GameObject cube;
    [SerializeField] private Color newColor;
     private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
     backgroundRenderer = backgroundWall.GetComponent<Renderer>();   
     cubeRenderer = cube.GetComponent<Renderer>();   
    }

    // Update is called once per frame
  
    public void ChangeBackground()
    {
        backgroundRenderer.material.color = newColor;
    }

    public void ChangeCubeColor()
    {
        cubeRenderer.material.color = newColor;
    }
}
