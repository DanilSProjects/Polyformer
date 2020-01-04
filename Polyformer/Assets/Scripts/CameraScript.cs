using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = 15.1497600001f / Screen.width * Screen.height;
        Camera.main.orthographicSize = x;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
