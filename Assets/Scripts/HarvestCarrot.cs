using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestCarrot : MonoBehaviour
{

    int Size = 9;     //Number of objects
    /*GameObject[] Carrots = new GameObject[Size];
    GameObject Carrot1;
    GameObject Carrot2;
    GameObject Carrot3;
    GameObject Carrot4;
    GameObject Carrot5;
    GameObject Carrot6;
    GameObject Carrot7;
    GameObject Carrot8;
    GameObject Carrot9;*/
    //bool harvested;
    // Start is called before the first frame update
    void Start()
    {
        //Carrots = [Carrot1, Carrot2, Carrot3, Carrot4, Carrot5, Carrot6, Carrot7, Carrot8, Carrot9];
        if (GameManager.LoadGame == true)
            //transform.position.y = PlayerPrefs.GetFloat(this.gameObject.Name);
            transform.position = new Vector3(transform.position.x, PlayerPrefs.GetFloat(this.gameObject.name), transform.position.z);
  
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
