using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverCheck : MonoBehaviour
{
    public  int canClickButtons = 0;
    public GameObject unlockeddoorsound;
    public void OnMouseEnter()
    {
        Debug.Log("aintrat");
        canClickButtons = 1;
        unlockeddoorsound.SetActive(true);
        
    }

}


