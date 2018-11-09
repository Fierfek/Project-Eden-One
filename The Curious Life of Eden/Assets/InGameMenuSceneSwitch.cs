using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuSceneSwitch : MonoBehaviour {
    public Canvas optionsMenu;
    public GameObject InGameUi;
    public void Start()
    {
        
    }

    //TO-DO: Code to pause game while ingame menu is active and resume while deactive
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.I))
        {
            if (optionsMenu.isActiveAndEnabled) //If InGameMenu is active and escape/I is pressed then set InGameMenu to false and InGameUI to true
            {
                InGameUi.SetActive(true);
                optionsMenu.gameObject.SetActive(false);
            }
            else //If InGameMenu is inactive and escape/I is pressed then set InGameMenu to true and InGameUI to false
            {
                InGameUi.SetActive(false);
                optionsMenu.gameObject.SetActive(true);
                //Code to pause the game goes here
            }
        }
            
    }
}
