using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Loops back to main menu scene on escape keypress
public class CreditsSceneSwitch : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);

	}
}
