using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Fire ();
		}
	}

	void Fire() {
		GameObject clone = (GameObject) Instantiate (bullet, transform.position, transform.rotation);
	}
}
