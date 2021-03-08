using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckThePlayerCamera : MonoBehaviour
{
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            gameObject.transform.rotation = new Quaternion(0f,180f, gameObject.transform.rotation.z, 0f);
            gameObject.transform.position = new Vector3(0f, 0f, 1f);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.rotation = new Quaternion(0f, 0f, gameObject.transform.rotation.z, 0f);
            gameObject.transform.position = new Vector3(0f, 0f, -1f);
        }

        if (Input.GetAxis("Vertical") > 0 || Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.rotation = new Quaternion(0f, gameObject.transform.rotation.y, 180f, 0f);
            gameObject.transform.position = new Vector3(0f, 0f, -1f);
        }
        else if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Vertical") < 0.21)
        {
            gameObject.transform.rotation = new Quaternion(0f, gameObject.transform.rotation.y, 0f, 0f);
            gameObject.transform.position = new Vector3(0f, 0f, -1f);
        }
    }
}
