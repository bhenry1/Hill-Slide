using UnityEngine;

public class Camera_Controller : MonoBehaviour 
{

	public Transform target;
	public float smoothSpeed = 0.125f;

	public Vector3 cameraOffset;



	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 desiredPostion = target.position + cameraOffset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPostion, smoothSpeed); // *Time.Delatime
		transform.position = desiredPostion;

		//transform.LookAt(target);


	}
}
