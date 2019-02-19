using UnityEngine;
using System.Collections;

public class blue_paint : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("ARCamera");
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
	}
}
