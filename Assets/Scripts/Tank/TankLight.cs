using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankLight : MonoBehaviour {

	public Light torch;
	private bool LightEnabled = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 

	{
		if(Input.GetButtonDown("torch"))
		{
			LightEnabled = true;
			torch.enabled = LightEnabled;
		}
	
			if(Input.GetButtonUp("torch"))
			{
			LightEnabled = false;
				torch.enabled = LightEnabled;
			}
	}
}
