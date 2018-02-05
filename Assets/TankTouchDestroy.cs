using UnityEngine;
using System.Collections;

public class TankTouchDestroy : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "TorchFollowTank")
		{
			Destroy(col.gameObject);
		}
	}
}