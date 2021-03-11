using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    [SerializeField] float maxD = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Layer 9 is the RaycastTrigger Layer. Only want to interact with objects here
        int layerMask = 1 << 9;
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Ray ray = new Ray(transform.position, fwd);

        Debug.DrawRay(transform.position, fwd * maxD, Color.red);

        if (Physics.Raycast(ray, out hit, maxD, layerMask))
        {
            if (hit.collider.gameObject.name.Equals("ToggleShaderPlane"))
            {
                
            }
        }
    }
}
