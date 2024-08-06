using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Res1024x576()
    {
        Screen.SetResolution(1024, 576, FullScreenMode.Windowed);
    }

    public void Res1280x720()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
    }

    public void Res1920x1080()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow);
    }
}
