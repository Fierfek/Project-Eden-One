using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		public void Quit()
        {
#if Unity_Editor
            Unity.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
