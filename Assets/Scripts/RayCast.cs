using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float range = 5;
    public AudioSource harvestCarrot;
    public AudioSource knock;
    //public HarvestCarrot raycastedObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));*/
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, 15))
        {
            if(hit.collider.CompareTag("Carrot"))
            {
                //raycastedObj = hit.collider.gameObject.GetComponent<HarvestCarrot>();
               if(Input.GetKey(KeyCode.E))
                {
                   HarvestingCarrot(hit.transform.gameObject);
                }
            }
            if(hit.collider.CompareTag("Door"))
            {
                if (Input.GetKey(KeyCode.E))
                {
                    KnockKnock(hit.transform.gameObject);
                }
            }
        }
    }

    void HarvestingCarrot(GameObject carrot)
    {
        Vector3 moveVect = new(0, 50.0f, 0);
        Vector3 newPosition = carrot.transform.position - moveVect;
        carrot.transform.position = newPosition;
        harvestCarrot.Play(0);
    }

    void KnockKnock(GameObject door)
    {
        knock.Play(0);
    }
}