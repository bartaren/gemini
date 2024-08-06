using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.TimeZoneInfo;

public class MainMenuScript : MonoBehaviour
{
    public Animator crossfade;
    public Animator transition;
    public float transitionTime;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Story Button").GetComponent<Button>().onClick.AddListener(() => {
            StartCoroutine(LoadLevel(2));
        });

        GameObject.Find("Add-ons Button").GetComponent<Button>().onClick.AddListener(() => {
            StartCoroutine(LoadLevel(3));
        });
    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel(int level)
    {
        crossfade.SetTrigger("Start");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
