using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHit : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioSource audio;
    [SerializeField] string hitText, pleasureText;
    [SerializeField] float speedThreshold;


    private float speedOfHittingObj;

   
   
    private void OnTriggerEnter(Collider obj)
    {
        
        if (obj.tag.Equals("HurtObject"))
        {
            speedOfHittingObj = obj.GetComponent<Rigidbody>().velocity.magnitude;
            anim.SetFloat(hitText, speedOfHittingObj);
            if(speedOfHittingObj >= speedThreshold)
            {
                audio.Play();
            }
           
        }

        else if (obj.tag.Equals("PleasureObject"))
        {
            speedOfHittingObj = obj.GetComponent<Rigidbody>().velocity.magnitude;
            anim.SetFloat(pleasureText, speedOfHittingObj);
        }
    }

   
}
