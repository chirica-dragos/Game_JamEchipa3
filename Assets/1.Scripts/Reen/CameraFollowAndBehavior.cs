using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowAndBehavior : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position = new Vector3(GameObject.Find("PlayerAvatar").GetComponent<Transform>().position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
