using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PageGet : MonoBehaviour
{

    public LevelLoaderScript LevelLoaderScript;

    public TMP_InputField input;
    int number;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    public void GoToPageInput()
    {
        Debug.Log(input.text);
        number = int.Parse(input.text);
        Debug.Log(number);

        if (GlobalToggles.AddOnToggle == false)
        {   
            if (number > 241)
                {number=241;}
            if (number < 1)
                {number=1;}
        }

        if (GlobalToggles.AddOnToggle == true)
        {   
            number = number + 243;
            if (number > 360)
                {number=360;}
            if (number < 244)
                {number=244;}
        }
        

        LevelLoaderScript.LoadALevel(number);
    }
}
