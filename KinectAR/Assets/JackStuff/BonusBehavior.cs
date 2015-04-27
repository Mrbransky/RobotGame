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
}
