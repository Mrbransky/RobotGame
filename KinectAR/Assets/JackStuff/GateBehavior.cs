using UnityEngine;
using System.Collections;

public class GateBehavior : MonoBehaviour {

	public States currentState;
	//GameObject[] otherGates = GameObject.FindGameObjectsWithTag("Gate");
	
	public enum States{
		slowField,
		wall,
		electricField
	}
	public void Update()
	{
		//GetComponent<LineRenderer> ().SetPosition (0, this.transform.position);
		//GetComponent<LineRenderer> ().SetPosition (1, otherGates [1].transform.position);
	}
}
