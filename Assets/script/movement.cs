using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotateSpeed = 50;
    public int carSpeed = 10;
    public float backflipSpeed = 360;
    public float jumpSpeed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Vertical") * Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * carSpeed * Time.deltaTime);
        if(transform.position.x  > 8) transform.position = new Vector3(8, transform.position.y, transform.position.z);
        if(transform.position.x  < -8) transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        if(transform.position.z  > 180) transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        //if car flips over
        if(transform.rotation.z > 45|| transform.rotation.z < -45){
            // transform.Rotate(0, 0, Input.GetAxis("Horizontal") * backflipSpeed * Time.deltaTime);
            //change the rotation to 0
            transform.rotation = Quaternion.Euler(0, 0,transform.rotation.z);
        }
        // if(transform.position.x  < -8) transform.position.x = -8;

        //change position to transform
        // transform.p
    }
}
