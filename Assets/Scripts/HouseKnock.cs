using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseKnock : MonoBehaviour
{
    public AudioSource knockKnock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider colli)
    {
        /*if (collision.gameObject.tag == "House")
        {
            knockKnock.Play(0);
        }*/
        if (Input.GetButtonDown("Interact"))
        {
            knockKnock.Play(0);
        }
    }
}
