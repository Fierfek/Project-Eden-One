using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void Exit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
