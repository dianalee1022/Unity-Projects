using UnityEngine;
using System.Collections;

public class CactusScript : MonoBehaviour {
	bool cactusActive = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			cactusActive = !cactusActive;
		}
		if (Input.GetKeyDown(KeyCode.R) && cactusActive)
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G) && cactusActive)
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B) && cactusActive)
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
