using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reen 8/3/2021 Created the script.






public class CharacterAnimationControl : MonoBehaviour
{
    public Animator CharacterAnimationController;
    void Update()
    {
        CharacterAnimationController.SetFloat("CurrentAcceleration", GetComponent<CharacterMovement>().Acceleration);
        CharacterAnimationController.SetBool("Grounded", GetComponent<CharacterMovement>().Grounded);
        if (Input.GetAxis("Horizontal") < 0)
            gameObject.GetComponent<Transform>().rotation = new Quaternion(0f, 180f, 0f, 0f);
        else if
           (Input.GetAxis("Horizontal") > 0)
            gameObject.GetComponent<Transform>().rotation = new Quaternion(0f, 0f, 0f, 0f);
    }
}
