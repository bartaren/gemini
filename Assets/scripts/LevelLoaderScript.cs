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
    public GameManager manager;

    // Start is called before the first frame update

    // Update is called once per frame

    private void Start() {
        manager = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        //Level = SceneManager.GetActiveScene().buildIndex;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            manager.Advance(manager.currentI + 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))    
        {
            manager.Advance(manager.currentI - 1);
        }

        //Debug.Log("MinLevel is" + MinLevel);
        //Debug.Log("MaxLevel is" + MaxLevel);
        //Debug.Log("Level is" + Level);
    }

    public void LoadAddOnLevel()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void LoadNextLevel()
    {
        manager.Advance(manager.currentI + 1);
        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreviousLevel()
    {
        manager.Advance(manager.currentI - 1);
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);
        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
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
        SceneManager.LoadScene("Main Menu");
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
