
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MicroMakePart : MonoBehaviour
{
    public OREO oreo;
    public float height = 0.25f;
    public string question;
    [HideInInspector] public SpriteRenderer sr;
    [HideInInspector] public int id;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
}
