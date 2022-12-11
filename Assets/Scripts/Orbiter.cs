using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public Transform world;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // world.Rotate(new Vector3(0,rotationSpeed,0), Space.World);
        //    world.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        world.transform.Rotate(0.0f,rotationSpeed, 0.0f, Space.World);
    }
}
