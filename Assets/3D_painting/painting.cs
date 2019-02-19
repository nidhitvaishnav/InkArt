using UnityEngine;
using System.Collections;

public class painting : MonoBehaviour {
    public GameObject bluepaint;
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButton(0))
        {
        Debug.LogWarningFormat("Inside update", GetType());
        Instantiate(bluepaint, transform.position, transform.rotation);
        }
	}
}
