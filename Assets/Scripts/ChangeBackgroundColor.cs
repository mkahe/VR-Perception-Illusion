using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundColor : MonoBehaviour
{
    public Renderer backgroundRenderer;
    public GameObject backgroundWall;
    [SerializeField] private Color newColor;
    [SerializeField] private Color[] colors;
     private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
     backgroundRenderer = backgroundWall.GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMaterial()
    {
        backgroundRenderer.material.color = newColor;
    }
}
