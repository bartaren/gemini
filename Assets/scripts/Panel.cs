using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using DG.Tweening;
using System.Linq;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip audioBackground;
    public AudioClip audioEffect;
    public AudioClip audioEffect2;

    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    [HideInInspector]
    public TextMeshPro text;

    [HideInInspector]
    public VideoPlayer videoPlayer;
    [HideInInspector]
    public RawImage rawImage;


    [HideInInspector]
    public Resizer resizer;

    [HideInInspector]
    public SpriteRenderer backpanelsprite;

    public bool HidePrev;
    public bool autoAdvance;
    private GameManager gameManager;
    public bool isDarkPanel;

    void Start()
    {
        
    }

    public void Init() {


        gameManager = FindAnyObjectByType<GameManager>();

        TryGetComponent(out spriteRenderer);
        TryGetComponent(out text);
        TryGetComponent(out videoPlayer);
        TryGetComponent(out rawImage);
        TryGetComponent(out resizer);

        if (resizer) {
            backpanelsprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RevealPanel() {

        if (audioBackground) {
            GameManager.audioeffect.Stop();//stop any old effects from playing(in case you quickly click through the pages)
            GameManager.backgroundaudio.clip = audioBackground;
            GameManager.backgroundaudio.Play();
        }
        if (audioEffect) {
            GameManager.audioeffect.clip = audioEffect;
            GameManager.audioeffect.Play();
        }
        if (audioEffect2) {
            GameManager.audioeffect2.clip = audioEffect2;
            GameManager.audioeffect2.Play();
        }


        if (HidePrev) {
            DOTween.KillAll();
            for (int i = 0; i < gameManager.currentI; i++) {
                var panel = gameManager.panels[i];
                if (panel.isDarkPanel == false) {
                    panel.SetAlpha(0f);
                } 
            };
            
        }

        //if (isDarkPanel) {
        //    var darkpanels = gameManager.panels.Where(p => p.isDarkPanel);
        //    foreach (var dp in darkpanels)
        //    {
        //        dp.spriteRenderer.DOFade(0.8f, 1);
        //        //dp.SetAlpha(0.8f);
                
        //    }
        //    spriteRenderer.DOFade(0, 1);
        //    //SetAlpha(0f);
        //    return;
        //    //hide self
        //    //set all the other dark panels to darken
        //}


        if (spriteRenderer) {
            var cc = spriteRenderer.color;
            cc.a = 1;
            spriteRenderer.color = cc;
            //spriteRenderer.DOColor(cc, 1);
        }
        //if (resizer) {
        //    var cc = backpanelsprite.color;
        //    cc.a = 1;
        //    backpanelsprite.DOColor(cc, 1);

        //    var cd = text.color;
        //    cd.a = 1;
        //    text.DOColor(cd, 1);
        //}else if (text) {
        //    //todo also fade in background if there
        //    var cc = text.color;
        //    cc.a = 1;
        //    text.DOColor(cc, 1);
        //}
        //if (rawImage && videoPlayer) {
        //    videoPlayer.Play();
        //    var cc = rawImage.color;
        //    cc.a = 1;
        //    rawImage.DOColor(cc, 1);
        //}
        


        
    }

    

    public void SetAlpha(float a) {
        
        //todo abort any ongoing tweens

        if (spriteRenderer) {
            var cc = spriteRenderer.color;
            cc.a = a;
            spriteRenderer.color = cc;
        }
        //if (resizer) {
        //    var cc = text.color;
        //    cc.a = a;
        //    text.color = cc;

        //    var cd = backpanelsprite.color;
        //    cd.a = a;
        //    backpanelsprite.color = cd;

        //}else if (text) {
        //    var cc = text.color;
        //    cc.a = a;
        //    text.color = cc;
        //}
        //if(rawImage) {
        //    var cc = rawImage.color;
        //    cc.a = a;
        //    rawImage.color = cc;
        //}
        
    }
}
