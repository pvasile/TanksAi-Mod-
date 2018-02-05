using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	public GameObject AITankScanner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Destroy (AITankScanner);
		}
			

}
}
