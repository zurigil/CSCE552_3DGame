using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 7.0f;
    float inputX;
    float inputZ;

    Rigidbody rigidBody;
    Vector3 moveVect;
    int lockPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //transform.rotation = Quaternion.Euler(lockPos, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        //transform.translate = Quaternion.Euler(position.x, lockPos, position.y);
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        moveVect = new Vector3(inputX, 0, inputZ);
        rigidBody.velocity = moveVect*moveSpeed;
    }

    /*void FixedUpdate()
    {
        //Vector3 moveVect = new Vector3(inputX, 0, inputY);
        //moveVect *= (moveSpeed * Time.deltaTime);
        // transform.Translate(moveVect);
        movePlayer(moveVect);
    }
    
    void movePlayer(Vector3 direction)
    {
        rigidBody.velocity = (moveVect * moveSpeed);
    }*/
}
