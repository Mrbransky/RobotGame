using UnityEngine;
using System.Collections;

public class BonusBehavior : MonoBehaviour {

	public States currentState;
	
	public enum States{
		endTrigger,
		speedBoost,
		attackBoost,
		stealthActivate,
		bossMonster
	}
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Tank")
        {
            switch (currentState)
            {
                case States.endTrigger:
                    break;
                case States.bossMonster:
                    break;
                case States.attackBoost:
                    break;
                case States.speedBoost:
                    break;
                case States.stealthActivate:
                    break;
                default:
                    break;
            }
            Destroy(this.gameObject);
        }
    }
}
