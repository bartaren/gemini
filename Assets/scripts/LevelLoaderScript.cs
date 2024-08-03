using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator crossfade;
    public Animator transition;
    public float transitionTime;

    public int MinLevel;
    public int MaxLevel;

    public int Level;

    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {
        Level = SceneManager.GetActiveScene().buildIndex;
        if (GlobalToggles.AddOnToggle == false)
        {   
            MinLevel = 1;
            MaxLevel = 242;
        }
        else
        {
            MinLevel = 244;
            MaxLevel = 361;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Level == MaxLevel){}
            else
            {
                LoadNextLevelNow();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))    
        {
            if (Level == MinLevel){}
            else
            {
                LoadPreviousLevelNow();
            }
        }

        Debug.Log("MinLevel is" + MinLevel);
        Debug.Log("MaxLevel is" + MaxLevel);
        Debug.Log("Level is" + Level);
    }

    public void LoadAddOnLevel()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreviousLevel()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    public void LoadNextLevelNow()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousLevelNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
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
        SceneManager.LoadScene(243);
    }

    public void LoadReplayA1()
    {
        StartCoroutine(LoadReplayB1());
    }

    IEnumerator LoadReplayB1()
    {
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(1);
    }

    public void LoadReplayA2()
    {
        StartCoroutine(LoadReplayB2());
    }

    IEnumerator LoadReplayB2()
    {
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(244);
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
