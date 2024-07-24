using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class Resizer : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshPro text;
    RectTransform rectTransform;

    SpriteRenderer spritechild;
    Transform spritetransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        text = GetComponent<TextMeshPro>();

        spritechild = GetComponentInChildren<SpriteRenderer>();
        var child = transform.GetChild(0);
        spritetransform = child.transform;
        //parent = transform.parent.GetComponent<SpriteRenderer>();
        //parenttransform = transform.parent;
        spritechild.size = text.textBounds.size + new Vector3(0.5f, 0.5f);
        spritetransform.localPosition = text.textBounds.center;
    }

    // Update is called once per frame
    void Update()
    {



        spritechild.size = text.textBounds.size + new Vector3(0.5f,0.5f);

        spritetransform.localPosition = text.textBounds.center;

        //text.ForceMeshUpdate();
        //text.textBounds.center;

        //calculate own size
        //set that size for the parent
        //set own position to top left
        //rectTransform.anchorMin;
        //rectTransform.anchorMax;
        //new Vector2(rec);


        //parenttransform.position = text.bounds.center;
        //rectTransform.anchoredPosition = (parent.bounds.size / 2) * -1;
        //set position to top left of parent
        //set width to width of parent
        //set heightn to height of parent
    }
}
