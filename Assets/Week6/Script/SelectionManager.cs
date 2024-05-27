using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private iRaycastProvider iRayProvider;
    private iSelector iSelector;
    private iSelectionMode iSelectionMode;

    private Transform currentSelection;

    private void Awake()
    {
        iRayProvider = GetComponent<iRaycastProvider>();
        iSelector = GetComponent<iSelector>();
        iSelectionMode = GetComponent<iSelectionMode>();
    }

    private void Update()
    {
        if(currentSelection != null)       
            iSelectionMode.onDeselect(currentSelection);
            iSelector.Check(iRayProvider.CreateRay());
            currentSelection = iSelector.GetSelection();

            if(currentSelection != null)
                iSelectionMode.onSelect(currentSelection);       
    }
}
