﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZNV_Tree : MonoBehaviour
{
    public Color hitColor;
    public MeshRenderer mr;

    private void OnCollisionEnter(Collision collision)
    {
        mr.material.color = hitColor;
        Debug.Log(collision.gameObject.name);

    }
}
