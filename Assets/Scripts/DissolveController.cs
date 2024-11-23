using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DissolveController : MonoBehaviour
{
    public float cutoff = .5f;
    public Renderer rend;
    void Update()
    {
        rend.material.SetFloat("_Cutoff", cutoff);
    }
}
