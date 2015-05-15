using UnityEngine;
using System.Collections;

public class ResourceBehavior : MonoBehaviour {

	public States currentState;
	
	public enum States{
        ArmorBuff,
        HealthPack,
        WeaponBuff

	}
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Tank")
        {
            switch (currentState)
            {
                case States.ArmorBuff:
                    coll.GetComponent<TankData>().armorLevel++;
                    break;
                case States.HealthPack:
                    coll.GetComponent<TankData>().health += 3;
                    break;
                case States.WeaponBuff:
                    coll.GetComponent<TankData>().weaponLevel++;
                    break;
                default:
                    break;
            }
            Destroy(this.gameObject);
        }
    }
}
