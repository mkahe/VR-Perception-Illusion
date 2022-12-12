using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public Transform world;
    public bool x_axis;
    public bool y_axis;
    public bool z_axis;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        world.transform.Rotate(x_axis ? rotationSpeed : 0.0f, y_axis ? rotationSpeed : 0.0f, z_axis ? rotationSpeed : 0.0f, Space.World);
    }
}
