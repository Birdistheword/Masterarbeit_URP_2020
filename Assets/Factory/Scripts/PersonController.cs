using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    //This script is so the working animation is offset by a random value
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        float r = Random.Range(0f, 1f);
        anim.SetFloat("Offset", r);
    }


}
