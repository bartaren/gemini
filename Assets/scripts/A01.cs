using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class A01 : MonoBehaviour
{
    public AudioSource source1;
    public AudioSource source2;

    public AudioClip clip1;
    public AudioClip clip2;

    public LevelLoaderScript LevelLoaderScript;

    
    public Animator crossfade;
    public Animator transition;
    public float transitionTime;


    int i;

    public EnableDisable EnableDisable;

    IEnumerator ButtonDelay(float sec)
    {
        EnableDisable.Trigger();
        yield return new WaitForSeconds(sec);
        EnableDisable.Trigger();
    }

    public void Advance1()
    {
        /*
        if (EffectsEnabler.EnableEffects == true)
        {
            StartCoroutine(ButtonDelay(1));
        }
        */
        
        Debug.Log("Hello");
        LevelLoaderScript.LoadNextLevelNow();

    }

    public void LoadALevel(int levelIndex)
    {
        StartCoroutine(LoadALevel1(levelIndex));
    }

    IEnumerator LoadALevel1(int levelIndex)
    {
            crossfade.SetTrigger("Start");
            transition.SetTrigger("Start");
            
            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(levelIndex);
    }

    
}
