using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System.IO;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    //todo
    // consider trying to move everything to 3dland
    // buy gemini
    // extract
    // import


    public List<Panel> panels;
    public int currentI = 0;
    public static AudioSource backgroundaudio;
    public static AudioSource audioeffect;
    public static AudioSource audioeffect2;
    public SpriteRenderer overlay;
    public MenuBar menu;
    public SpriteRenderer wipe;

    void Start()
    {
        //var barmenu = Instantiate(Resources.Load("barmenu")).GetComponent<Canvas>();
        //barmenu.worldCamera = Camera.main;
        //var canvaspanel = barmenu.transform.Find("Panel");
        //canvaspanel.position = new Vector3(0,-1000,0);
        menu = FindAnyObjectByType<MenuBar>();
        
        wipe = GameObject.Find("wipe").GetComponent<SpriteRenderer>();
        overlay = GameObject.Find("overlay").GetComponent<SpriteRenderer>();
        backgroundaudio = GameObject.Find("backgroundAudio").GetComponent<AudioSource>();
        audioeffect = GameObject.Find("audioeffect").GetComponent<AudioSource>();
        audioeffect2 = GameObject.Find("audioeffect2").GetComponent<AudioSource>();

        panels = FindObjectsOfType<Panel>().OrderBy(p => p.transform.GetSiblingIndex()).ToList();

        //var files = new DirectoryInfo("./Assets/Scenes").GetFiles();
        

        foreach (var panel in panels){
            panel.Init();
            //panel.SetAlpha(0f);
            //if(panel.isDarkPanel == false) {
            //    panel.SetAlpha(0);
            //}
        }

        if (panels.Count > 0) {
            panels[0].RevealPanel();
        }

        //this.CallWithDelay(() => {
            
        //}, 1);
        

        wipe.transform.DOMoveX(-25, 2).From(0).SetDelay(1).OnComplete(() => {
            
        });

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Advance(currentI - 1);
        } else if(Input.GetKeyDown(KeyCode.RightArrow)) {
            Advance(currentI + 1);
        }

        
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject() == false) {
            Advance(currentI + 1);
        }
    }

    public void Advance(int index) {
        currentI = index;
        if (currentI >= panels.Count) {
            if (currentI > panels.Count) {
                return;
            }
            //int index = int.Parse(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("MainMenu");

        } else {
            currentI = Mathf.Clamp(currentI, 0, panels.Count - 1);
            menu.input.text = (currentI + 1).ToString();

            panels[currentI].RevealPanel();
            Camera.main.transform.position = panels[currentI].transform.position + new Vector3(0,0,-10);

            if (backgroundaudio.isPlaying == false || backgroundaudio?.clip?.name  == "silence") {
                for (int i = currentI; i >= 0; i--) {
                    var panel = panels[i];
                    if (panel.audioBackground != null) {
                        backgroundaudio.clip = panel.audioBackground;
                        backgroundaudio.Play();
                        break;
                    }

                }

            }

        }
    }

    //bool isTransitioningToNewScene = false;
    //void LoadScene(int index) {
    //    if(isTransitioningToNewScene) {
    //        return;
    //    }
    //    isTransitioningToNewScene = true;
    //    overlay.transform.localPosition = new Vector3(0, 0, 6);
    //    overlay.DOColor(new Color(0, 0, 0, 1), 3).From(new Color(0, 0, 0, 0));

    //    var scenenames = getallscenes();
    //    var scene = scenenames.Find(s => s == index.ToString());

    //    wipe.transform.DOMoveX(0, 2).SetEase(Ease.Linear).OnComplete(() => {
    //        if (scene != null) {
    //            SceneManager.LoadScene(scene);
    //        } else {
    //            SceneManager.LoadScene("MainMenu");
    //        }

    //    });
    //}

    //List<string> getallscenes() {
    //    return EditorBuildSettings.scenes.Select(s => Path.GetFileNameWithoutExtension(s.path)).ToList();
    //}
}
