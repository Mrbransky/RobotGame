using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TowerBehavior : MonoBehaviour {

	public bool isActive;
    bool missleCooldownActive = false;
    public GameObject misslePrefab;
	public States currentState;
    public float timeTilNextShot = 2;
    float startTime;

    //Stats
    public int health = 5;
    public int armor;

	public enum States{
		longRange,
		shortRange,
		staticRange
	}
    void Start()
    {
        startTime = timeTilNextShot;
    }
	public void Update()
	{
        if (missleCooldownActive == true)
        {
            timeTilNextShot -= Time.deltaTime;
            if (timeTilNextShot <= 0)
            {
                missleCooldownActive = false;
                timeTilNextShot = startTime;
            }
        }

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
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Tank" && missleCooldownActive == false)
        {
            GameObject firedMissle = Instantiate(misslePrefab, this.transform.position + new Vector3(0,1,0), Quaternion.identity) as GameObject;
            firedMissle.transform.LookAt(coll.transform.position);
            missleCooldownActive = true;
        }
    }
}
