using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float bulletSpeed;

	void Start() {
		bulletSpeed = 50;
	}

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * bulletSpeed, Space.World);
		StartCoroutine ("Wait");
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (10f);
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.transform.tag == "Plane") {
			Debug.Log ("Plane hit!");
			Destroy(gameObject);
		}
	}
}
