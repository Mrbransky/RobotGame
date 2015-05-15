using UnityEngine;
using System.Collections;

public class MoveThenDestroy : MonoBehaviour {

    public float TimeTilDestroy = 3;
    public float speed = 5;
	// Update is called once per frame
	void Update () {
        TimeTilDestroy -= Time.deltaTime;

        if (TimeTilDestroy <= 0)
        {
            Destroy(this.gameObject);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
