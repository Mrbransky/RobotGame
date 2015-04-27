using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	//TowerBehavior[] modes;

	public bool checkGates = true;

	public GameObject[] Towers;
	public GameObject[] Resources;
	public GameObject[] Gates;
	public GameObject[] Bonus;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Towers = GameObject.FindGameObjectsWithTag ("Tower");
		Resources = GameObject.FindGameObjectsWithTag ("Resource");
		Gates = GameObject.FindGameObjectsWithTag ("Gate");
		Bonus = GameObject.FindGameObjectsWithTag ("Bonus");

		CreateGates ();
	}
	void CreateGates()
	{
		if (checkGates == true) {
			GetComponent<LineRenderer>().SetVertexCount(Gates.Length);
			for (int i = 0; i <= Gates.Length; i++) {
				Debug.Log (i);
				
				GetComponent<LineRenderer> ().SetPosition (i, Gates [i].transform.position);
				
				if (i == 1) {
					checkGates = false;
				}
			}
		}
	}
}
