using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class A02 : MonoBehaviour
{

    public CanvasGroup[] uiElement;

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    public UIFader2 UIFader2;
    public LevelLoaderScript LevelLoaderScript;

    int i;

    public EnableDisable EnableDisable;

    IEnumerator ButtonDelay(float sec)
    {
        EnableDisable.Trigger();
        yield return new WaitForSeconds(sec);
        EnableDisable.Trigger();
    }

    public void Advance2()
    {
        if (EffectsEnabler.EnableEffects == true)
        {
            StartCoroutine(ButtonDelay(1));
        }
        
        Debug.Log("Hello");
        if (i == 0)
        {
            UIFader2.FadeIn2(uiElement[i]);
            source1.PlayOneShot(clip1);
        }


        if (i == 1)
        {
            UIFader2.FadeIn2(uiElement[i]);
            source2.PlayOneShot(clip2);
        }
        
        if (i == 7)
        {
            UIFader2.FadeIn2(uiElement[i]);
            /*source3.PlayOneShot(clip3);*/
        }

        if (i == 10)
        {
            LevelLoaderScript.LoadNextLevel();
        }

        UIFader2.FadeIn2(uiElement[i]);

        i = i + 1;

        Debug.Log(i);

    }

}
