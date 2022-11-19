using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestCarrot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //Ray landingRay = newRay(transform.position, Vector3.forward);

        //if(hit.collider.tag == "carrot")
        //{

        //}
    }

    void HarvestingCarrot()
    {
        Vector3 originalVect = new(69.36f, 4.94f, 49.58f);
        Vector3 moveVect = new(69.36f, 50.0f, 49.58f);
        transform.position = moveVect;
        
    }
}
