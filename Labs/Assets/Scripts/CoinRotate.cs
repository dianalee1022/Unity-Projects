using UnityEngine;
using System.Collections;

public class CoinRotate : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (45, 0, 0) * Time.deltaTime);
	}
}
