using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iSelector
{
    void Check(Ray ray);

    Transform GetSelection();
    
}