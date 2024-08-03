using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableBarMenu : MonoBehaviour
{
    
    public UIFader3 UIFader3;
    public GameObject pic1;
    public CanvasGroup pic2;
    public GameObject pic3;
    public GameObject pic4;


    IEnumerator WaitEnable()
    {
        pic1.SetActive(true);
        UIFader3.FadeIn2(pic2);
        yield return new WaitForSeconds(0.5f);
        pic3.SetActive(false);
        pic4.SetActive(true);
    }

    IEnumerator WaitDisable()
    {
        UIFader3.FadeOut2(pic2);
        yield return new WaitForSeconds(0.5f);
        pic1.SetActive(false);
        pic4.SetActive(false);
        pic3.SetActive(true);
    }

    public void TriggerBar()
    {
        
        if(pic1.activeInHierarchy == false)
        {StartCoroutine(WaitEnable());}

        else
        {StartCoroutine(WaitDisable());}

        
    }
}
