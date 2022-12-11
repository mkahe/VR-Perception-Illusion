using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    public void OnFirstButtonClick()
    {
        GameObject player = GameObject.Find("XR Origin");
        player.transform.position = new Vector3(0 , -6, -6);
    }

    public void OnSecondButtonClick()
    {
        GameObject player = GameObject.Find("XR Origin");
        player.transform.position = new Vector3(20 , -6, -6);
    }
        public void OnThirdButtonClick()
    {
        GameObject player = GameObject.Find("XR Origin");
        player.transform.position = new Vector3(40 , -6, -6);
    }
        public void OnForthButtonClick()
    {
        GameObject player = GameObject.Find("XR Origin");
        player.transform.position = new Vector3(60 , -6, -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
