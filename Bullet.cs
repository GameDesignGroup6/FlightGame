using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float bulletSpeed;
	public GameObject explosion;

	void Update () {
		transform.Translate (Vector3.forward * bulletSpeed * Time.deltaTime);
		StartCoroutine ("Wait");
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (10f);
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.transform.tag == "Plane") {
			Debug.Log ("Plane hit!");
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
