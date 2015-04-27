using UnityEngine;
using System.Collections;

public class TowerBehavior : MonoBehaviour {

	public bool isActive;
	public States currentState;

	public enum States{
		longRange,
		shortRange,
		staticRange
	}
	public void Update()
	{
		switch (currentState) {
		case States.longRange:
			renderer.material.color = Color.blue;
			GetComponent<CapsuleCollider>().radius = 5;
			break;
		case States.shortRange:
			renderer.material.color = Color.green;
			GetComponent<CapsuleCollider>().radius = 3;
			break;
		case States.staticRange:
			renderer.material.color = Color.red;
			GetComponent<CapsuleCollider>().radius = 2.6F;
			break;
		default:
			break;
		}
	}
}
