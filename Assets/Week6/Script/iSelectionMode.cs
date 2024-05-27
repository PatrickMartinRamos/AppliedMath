using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iSelectionMode
{
    void onSelect(Transform selection);

    void onDeselect(Transform selection);
}
