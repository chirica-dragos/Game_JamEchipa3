using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuckThePlayerCharacter : MonoBehaviour
{
    public GameObject Camera;
    public GameObject TextDisplay;
    public GameObject TextCounter;
    private GameObject MemorizePlayer;

    public bool CounterActive;
    public float CounterValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        TextCounter.GetComponent<Text>().text = "0";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MemorizePlayer = collision.gameObject;
        Camera.GetComponent<CameraFollowAndBehavior>().follow = false;
        MemorizePlayer.SetActive(false);
        CounterActive = true;
        TextDisplay.SetActive(true);
    }
    void FixedUpdate()
    {
        if(CounterActive == true)
        {
            CounterValue += Time.realtimeSinceStartup-Time.time;
            TextCounter.GetComponent<Text>().text = Mathf.FloorToInt(CounterValue/100).ToString();
        }    
        if(Input.GetKey(KeyCode.Insert) && CounterActive == true)
        {
            TextDisplay.SetActive(false);
            CounterActive = false;
            CounterValue = 0f;
            MemorizePlayer.GetComponent<Transform>().rotation = default;
            Camera.GetComponent<Transform>().rotation = default;
            Camera.GetComponentInChildren<SpriteRenderer>().flipY = false;
            Camera.GetComponentInChildren<SpriteRenderer>().flipX = false;
            Camera.GetComponent<Transform>().position = new Vector3(Camera.GetComponent<Transform>().position.x, Camera.GetComponent<Transform>().position.y, -1f);
            MemorizePlayer.GetComponent<Transform>().position = new Vector2(-7.15f, -3.35f);
            Camera.GetComponent<CameraFollowAndBehavior>().follow = true;
            MemorizePlayer.SetActive(true);
        }
        if (CounterValue > 9900)
            Application.Quit();
    }
}
