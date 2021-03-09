using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverCheck : MonoBehaviour
{
    public  int canClickButtons = 0;
    public void OnMouseEnter()
    {
        Debug.Log("aintrat");
        canClickButtons = 1;
        
    }

}


