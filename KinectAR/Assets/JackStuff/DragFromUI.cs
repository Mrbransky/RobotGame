using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DragFromUI : MonoBehaviour {

	public GameObject PrefabToSpawn;
    Vector2 startPos;
    void Start()
    {
        startPos = this.transform.position;
    }
	public void Drag()
	{
        Debug.Log(startPos);
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,10));
	}
	public void Drop()
	{

		Instantiate (PrefabToSpawn, new Vector3(this.transform.position.x,2, this.transform.position.z), Quaternion.identity);
        this.transform.position = startPos;

	}
}
