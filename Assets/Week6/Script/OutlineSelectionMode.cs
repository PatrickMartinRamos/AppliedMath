using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutlineSelectionMode : MonoBehaviour, iSelectionMode
{

    public void onDeselect(Transform selection)
    {
        Outline outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 0;
        }
    }
    public void onSelect(Transform selection)
    {
        Outline outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 10;
        }
    }
}
