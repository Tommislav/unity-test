using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	
	void Update () {
		if (Input.GetMouseButton (0)) {
			Application.LoadLevel("Level");
		}
	}
}
