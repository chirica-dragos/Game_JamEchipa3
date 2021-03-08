using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    
    public MouseOverCheck script;

    public GameObject butonstart;
    public GameObject optionsbutton;
    public GameObject quitsettingsbutton;
    public GameObject settingsMenu;
    public GameObject mainMenu;

    int numaratorApasariButonStart = 0;
    int numaratorApasariButonOptions = 0;

    


    public void startButton()
    {
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 0)
        {

            
            butonstart.transform.position = new Vector3(150, 450, 0);
            numaratorApasariButonStart++;

        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 1)
        {

            
            butonstart.transform.position = new Vector3(300, 100, 0);
            numaratorApasariButonStart++;
        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 2)
        {

            
            butonstart.transform.position = new Vector3(50, 200, 0);
            numaratorApasariButonStart++;
        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 3)
        {

            
            butonstart.transform.position = new Vector3(390, 175, 0);
            numaratorApasariButonStart++;
        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 4)
        {

            Debug.Log("felicitari, ai apasat pe buton");
            butonstart.transform.position = new Vector3(460, 350, 0);
            numaratorApasariButonStart++;
        }
    }
    
    public void optionsButton() {
        if (script.canClickButtons == 1)
        {
            settingsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
    }


    public void quitsettings()
    {
        if (script.canClickButtons == 1)
        {
            settingsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    void Start()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
