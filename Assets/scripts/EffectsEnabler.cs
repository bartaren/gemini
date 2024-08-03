using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsEnabler : MonoBehaviour
{

    public static bool EnableEffects;

    void Awake()
    {
        EnableEffects = true;
        Debug.Log(EnableEffects);
    }

    public void EffectsEnable()
    {
        EnableEffects = true;
    }
    public void EffectsDisable()
    {
        EnableEffects = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
