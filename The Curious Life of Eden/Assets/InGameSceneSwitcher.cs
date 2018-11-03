using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSceneSwitcher : MonoBehaviour {
    public void SceneSwitcher()
    {
        SceneManager.LoadScene(3);
    }
}
