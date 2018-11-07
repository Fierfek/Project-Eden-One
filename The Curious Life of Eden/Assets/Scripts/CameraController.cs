using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    Camera camera;
    public Transform target;

    private float maxDelta = 0f;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        maxDelta = Vector3.Distance(transform.position, target.position) / (Mathf.Pow(1.02f, 2));
        transform.position = Vector3.MoveTowards(transform.position, target.position, maxDelta);
	}

    public void setTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
