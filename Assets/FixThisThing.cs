using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FixThisThing : MonoBehaviour
{
    public TMP_InputField inputfield;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
        GameObject.Find("Back Button").GetComponent<Button>().onClick.AddListener(() => {
            manager.Advance(manager.currentI - 1);
        });
        GameObject.Find("Next Button").GetComponent<Button>().onClick.AddListener(() => {
            manager.Advance(manager.currentI + 1);
        });
        GameObject.Find("Title Button").GetComponent<Button>().onClick.AddListener(() => {
            SceneManager.LoadScene("Main Menu");
        });

        var background = GameObject.Find("Background");
        
        GameObject.Find("Maximize Button").GetComponent<Button>().onClick.AddListener(() => {
            background.SetActive(true);
        });
        GameObject.Find("Minimize Button").GetComponent<Button>().onClick.AddListener(() => {
            background.SetActive(false);
        });

        inputfield = GameObject.Find("pageinput").GetComponent<TMP_InputField>();
        GameObject.Find("Skip Button").GetComponent<Button>().onClick.AddListener(() => {
            int number = int.Parse(inputfield.text);
            manager.Advance(number - 1);
        });

        background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
