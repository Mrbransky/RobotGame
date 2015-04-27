using UnityEngine;
using System.Collections;

public class ButtonTest : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject planet;
	// Use this for initialization
	void Start () {
		// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			// Register with the virtual buttons TrackableBehaviour
			vbs[i].RegisterEventHandler(this);
		}

		planet.SetActive (false);
	}
	
	/// <summary>
	/// Called when the virtual button has just been pressed:
	/// </summary>
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) { 

		if (vb.VirtualButtonName == "Test") {
		
			planet.SetActive(true);
		
		}
	
	}
	
	/// <summary>
	/// Called when the virtual button has just been released:
	/// </summary>
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

	}
}
