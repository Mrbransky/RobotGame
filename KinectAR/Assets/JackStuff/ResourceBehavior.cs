using UnityEngine;
using System.Collections;

public class ResourceBehavior : MonoBehaviour {

	public States currentState;
	
	public enum States{
        ArmorBuff,
        HealthPack,
        WeaponBuff

	}
}
