using UnityEngine;
using System.Collections;

public class LightingScript : MonoBehaviour {
	float duration = 1f;
	Color color0 = Color.red;
	Color color1 = Color.blue;
	Color color2 = Color.green;
	Color color3 = Color.white;
	bool isLight = false;

	Light lt;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		// set light color
		float t = Mathf.PingPong(Time.time, duration) / duration;
		if (Input.GetKeyDown(KeyCode.L))
		{
			isLight = !isLight;
		}
		if (Input.GetKeyDown(KeyCode.R) && isLight)
		{
			lt.color = Color.Lerp(color0, color1, t);
		}
		if (Input.GetKeyDown(KeyCode.G) && isLight)
		{
			lt.color = Color.Lerp(color1, color2, t);
		}
		if (Input.GetKeyDown(KeyCode.B) && isLight)
		{
			lt.color = Color.Lerp(color2, color0, t);
		}
		if (Input.GetKeyDown(KeyCode.W) && isLight)
		{
			lt.color = Color.Lerp(color0, color3, t);
		}
	}
}
