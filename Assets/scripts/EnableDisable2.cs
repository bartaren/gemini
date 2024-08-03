using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable2 : MonoBehaviour
{
    public GameObject pic;
    public CanvasGroup pic2;
    public UIFader2 UIFader2;

    public void Trigger2()
    {
        StartCoroutine(Triggerx2());
    }

    IEnumerator Triggerx2(){
        if(pic.activeInHierarchy == false)
        {
            pic.SetActive(true);
            UIFader2.FadeIn2(pic2);
        }
        else
        {
            UIFader2.FadeOut2(pic2);
            yield return new WaitForSeconds(1);
            pic.SetActive(false);
        }
    }
}