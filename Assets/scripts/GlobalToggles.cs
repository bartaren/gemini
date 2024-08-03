using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalToggles : MonoBehaviour
{

    public static bool AddOnToggle;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
    }

    // Update is called once per frame

    public void AddOnToggleTrue()
    {
        AddOnToggle = true;
    }

    public void AddOnToggleFalse()
    {
        AddOnToggle = false;
    }

    void Update()
    {
        Debug.Log(AddOnToggle);
    }
}
