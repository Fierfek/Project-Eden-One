using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUIOnButtonClick : MonoBehaviour {
    public GameObject activateUI; //UI to be set active after click
    public GameObject deactivateUI;//UI to be set deactive after click

	public void setUIActive()
    {
        activateUI.SetActive(true);
        deactivateUI.SetActive(false);
    }
}
