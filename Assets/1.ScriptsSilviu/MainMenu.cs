using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    
    public MouseOverCheck script;

    public GameObject butonstart;
    public GameObject optionsbutton;
    public GameObject quitsettingsbutton;
    public GameObject settingsMenu;
    public GameObject mainMenu;
    public GameObject achievementsbutton;
    public GameObject screamer;
    public GameObject loadgame;


    int numaratorApasariButonStart = 0;
    int numaratorApasariButonOptions = 0;
    int numaratorApasariButonBack = 0;
    int numaratorApasariButonAchievements = 0;
    int numaratorApasariButonLoad = 0;
    IEnumerator Scream()
    {
        screamer.SetActive(true);
        
        yield return new WaitForSeconds(2);
        screamer.SetActive(false);
        }
    public void loadButton()
    {

    }

    public void achievementsButton()
    {
        if(script.canClickButtons == 1 && numaratorApasariButonAchievements == 0)
        {
            achievementsbutton.transform.position = new Vector3(333, 86,0);
            numaratorApasariButonAchievements++;
           
        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 1)
        {
            achievementsbutton.transform.position = new Vector3(1493, 102,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 2)
        {
            achievementsbutton.transform.position = new Vector3(1480, 792,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 3)
        {
            achievementsbutton.transform.position = new Vector3(824, 388,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 4)
        {
            achievementsbutton.transform.position = new Vector3(688, 831,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 5)
        {
            achievementsbutton.transform.position = new Vector3(1171, 1003,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 6)
        {
            achievementsbutton.transform.position = new Vector3(1759, 560,0);
            numaratorApasariButonAchievements++;

        }
        else
             if (script.canClickButtons == 1 && numaratorApasariButonAchievements == 7)
        {
            achievementsbutton.transform.position = new Vector3(538, 570,0);
            numaratorApasariButonAchievements++;

        }
        else
            if(script.canClickButtons == 1 && numaratorApasariButonAchievements == 8)
        {
            achievementsbutton.transform.position = new Vector3(233, 193, 0);
            numaratorApasariButonAchievements = 0;
            StartCoroutine(Scream());

            
        }
    }

    


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

            
            butonstart.transform.position = new Vector3(460, 350, 0);
            numaratorApasariButonStart++;
        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 5)
        {

            
            butonstart.transform.position = new Vector3(273.9f, 914.97f, 0);
            numaratorApasariButonStart++;
        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 6)
        {

            
            
            butonstart.transform.position = new Vector3(1623, 835, 0);
            numaratorApasariButonStart++;

        }
        else
        if (script.canClickButtons == 1 && numaratorApasariButonStart == 7)
        {

            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            butonstart.transform.position = new Vector3(246, 905, 0);
            
        }
    }
    
    public void optionsButton() {

        if(script.canClickButtons == 1 && numaratorApasariButonOptions == 0)
        {
            optionsbutton.transform.position = new Vector3(570, 400, 0);
            numaratorApasariButonOptions++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 1)
        {
            optionsbutton.transform.position = new Vector3(1471, 940, 0);
            numaratorApasariButonOptions++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 2)
        {
            optionsbutton.transform.position = new Vector3(1019, 87, 0);
            numaratorApasariButonOptions++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 3)
        {
            optionsbutton.transform.position = new Vector3(765, 456, 0);
            numaratorApasariButonOptions++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 4)
        {
            optionsbutton.transform.position = new Vector3(270, 498, 0);
            numaratorApasariButonOptions++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 5)
        {
            optionsbutton.transform.position = new Vector3(1465, 871, 0);
            numaratorApasariButonOptions++;
        }


        else
            if (script.canClickButtons == 1 && numaratorApasariButonOptions == 6 )
        {
            numaratorApasariButonOptions = 0;
            optionsbutton.transform.position = new Vector3(246, 455, 0);
            settingsMenu.SetActive(true);
            mainMenu.SetActive(false);
            
        }
    }


    public void quitsettings()
    {
        
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 0)
        {
            quitsettingsbutton.transform.position = new Vector3(1768, 166,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 1)
        {
            quitsettingsbutton.transform.position = new Vector3(185, 924,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 2)
        {
            quitsettingsbutton.transform.position = new Vector3(460, 330,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 3)
        {
            quitsettingsbutton.transform.position = new Vector3(1665, 789,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 4)
        {
            quitsettingsbutton.transform.position = new Vector3(773, 354,0);
            numaratorApasariButonBack++;
        }


        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 5)
        {
            quitsettingsbutton.transform.position = new Vector3(940, 1003,0);
            numaratorApasariButonBack++;
        }

        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 6)
        {
            quitsettingsbutton.transform.position = new Vector3(1407, 703,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 7)
        {
            quitsettingsbutton.transform.position = new Vector3(989, 525,0);
            numaratorApasariButonBack++;
        }
        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 8)
        {
            quitsettingsbutton.transform.position = new Vector3(333, 86,0);
            numaratorApasariButonBack++;
        }

        else
            if (script.canClickButtons == 1 && numaratorApasariButonBack == 9)
        {
            settingsMenu.SetActive(false);
            mainMenu.SetActive(true);
            numaratorApasariButonBack = 0;
            quitsettingsbutton.transform.position = new Vector3(964, 497, 0);
        }
    }
    void Start()
    {
        
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
        screamer.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
