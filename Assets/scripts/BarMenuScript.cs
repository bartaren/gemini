using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarMenuScript : MonoBehaviour
{

    public UIFader2 UIFader2;
    public CanvasGroup BarMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BarMenuFadeIn()
    {
        UIFader2.FadeIn2(BarMenu);
    }

    public void BarMenuFadeOut()
    {
        UIFader2.FadeOut2(BarMenu);
    }

}
