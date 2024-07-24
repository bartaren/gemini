using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBar : MonoBehaviour
{

    public TMP_InputField input;
    public Button gotobtn;
    public Button menubtn;
    public Button toggle;
    public RectTransform panel;
    GameManager manager;

    void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
        input.text = "1";

        gotobtn.onClick.AddListener(() => {
            GameManager.backgroundaudio.Stop();
            GameManager.audioeffect.Stop();
            manager.Advance(int.Parse(input.text) - 1);
            panel.gameObject.SetActive(false);
        });

        menubtn.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");
        });

        toggle.onClick.AddListener(() => {

            panel.gameObject.SetActive(!panel.gameObject.activeSelf);
            //if (panel.anchoredPosition.magnitude < 10) {
            //    panel.anchoredPosition = new Vector3(0,-1000,0);
            //} else {
            //    panel.anchoredPosition = Vector3.zero;
            //}
            
        });
    }

    void Update()
    {
        
    }
}
