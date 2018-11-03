using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Loads scene at sceneIndex
public class SceneSwitchOnButtonClick : MonoBehaviour {
    public int sceneIndex;
    public void SceneSwitch()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
