using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager))]
public class EditorHelp : Editor
{

    public override void OnInspectorGUI() {

        GameManager gameManager = (GameManager)target;
        DrawDefaultInspector();

        if (GUILayout.Button("Organize panels")) {
            var panels = FindObjectsOfType<Panel>().OrderBy(p => p.transform.GetSiblingIndex()).ToList();

            int width = 10;
            
            for(int y = 0; y < 1000; y++) {
                for (int x = 0; x < width; x++) {
                    int i = x + y * width;
                    if(i >= panels.Count) {
                        goto foo;
                    }
                    var panel = panels[i];
                    panel.transform.position = new Vector3(x*25,y*-15,0);
                }
            }
            foo:
            Debug.Log("It's alive: " + target.name);
        }
            
    }

}
