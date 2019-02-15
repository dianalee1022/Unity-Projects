using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	private bool isTransform = true;
	private bool isRotation = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.T)) {
			isTransform = true;
			isRotation = false;
		}
		if (Input.GetKeyDown(KeyCode.R)) {
			isTransform = false;
			isRotation = true;
		}
		if (Input.GetKeyDown(KeyCode.W)) {
			if (isTransform) {
				transform.Translate (Vector3.forward * 10f * Time.deltaTime);
			}
			if (isRotation) {
				transform.Rotate (Vector3.left, 50f * Time.deltaTime);
			}
		}
		if (Input.GetKeyDown(KeyCode.X)) {
			if (isTransform) {
				transform.Translate (-Vector3.forward * 10f * Time.deltaTime);
			}
			if (isRotation) {
				transform.Rotate (Vector3.left, -50f * Time.deltaTime);
			}
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			if (isTransform) {
				transform.Translate (Vector3.left * 10f * Time.deltaTime);
			}
			if (isRotation) {
				transform.Rotate (Vector3.up, -50f * Time.deltaTime);
			}
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			if (isTransform) {
				transform.Translate (-Vector3.left * 10f * Time.deltaTime);
			}
			if (isRotation) {
				transform.Rotate (Vector3.up, 50f * Time.deltaTime);
			}
		}
	}
}
