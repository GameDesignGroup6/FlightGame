using UnityEngine;
using System.Collections;

public class CrashScript : MonoBehaviour {

	//these variables can be turned into private once the value is finalized
	public float groundLevel;
	public float crashVelocityThreshold;
	public Transform crashedAirPlane;
	// Use this for initialization
	void Start () {
	

		groundLevel = 1.0;
		crashVelocityThreshold = 100;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void crash(){
		if ((GetYPosition() <groundLevel)&&(GetAirSpeed>crashVelocityThreshold)){
			Instantiate(crashedAirPlane, gameObject.rigidbody.position, gameObject.rigidbody.rotation);
			Destroy(gameObject);
			Debug.Log ("Plane " + gameObject.name + " crashed");
		}
	}

	/**
	 *This method uses speed in m/s not knots
	 */
	public float GetAirSpeed(){
		return gameObject.rigidbody.velocity.magnitude;
	}
	public float GetYPosition(){
		return gameObject.rigidbody.position.y;
	}
}
