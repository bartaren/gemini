using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public int transitionTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntroLoad(1));
    }

    IEnumerator IntroLoad(int level)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
