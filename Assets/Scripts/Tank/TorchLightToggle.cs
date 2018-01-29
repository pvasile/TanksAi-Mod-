using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLightToggle : MonoBehaviour {

	public Light torch;

	// Use this for initialization
	void Start () {
		torch = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		//TOGGLE LIGHT ON/OFF WHEN L KEY IS PRESSED
		if (Input.GetKeyDown(KeyCode.L))
		{
			torch.enabled = !torch.enabled;
	}
}
}
