using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript2 : MonoBehaviour
{
    public Animator crossfade;
    public Animator transition;
    public float transitionTime;

    // Start is called before the first frame update

    // Update is called once per frame
    public void LoadAddOnLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreviousLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex -1));
    }

    public void LoadNextLevelNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousLevelNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
            crossfade.SetTrigger("Start");
            transition.SetTrigger("Start");
            
            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(levelIndex);
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

    public void LoadTitle()
    {
        StartCoroutine(LoadTitle1());
    }

    IEnumerator LoadTitle1()
    {   
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(1);
    }

    public void LoadReplay()
    {
        StartCoroutine(LoadReplay1());
    }

    IEnumerator LoadReplay1()
    {
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(1);
    }

    public void LoadReplayCurrent()
    {
        StartCoroutine(LoadReplayCurrent1());
    }

    IEnumerator LoadReplayCurrent1()
    {
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
