using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatherineController : MonoBehaviour
{
    [SerializeField] Animator anim;

  
    // Little Fix to reset the speed, not worth it to find a more elegant solution
    public void ResetSpeed()
    {
        anim.SetFloat("hit_intensity", 0);
        anim.SetFloat("stroke_intensity", 0);
        anim.SetFloat("face_stroke_intensity", 0);
        anim.SetFloat("face_hit_intensity", 0);
    }
}
