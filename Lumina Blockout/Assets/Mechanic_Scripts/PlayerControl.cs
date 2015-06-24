using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{

	public static PlayerControl instance;

	public float moveSpeed = 5;
	public float moveSpeedSmooth = 0.3f;
	public float rotateSpeed = 10;
	public float rotateSpeedSmooth = 0.3f;
	public float jumpSpeed = 20;
	public float gravity = 9.8f;

	float currentForwardSpeed;
	float forwardSpeedV;

	float targetRotation;
	float currentRotation;
	float rotationV;

	Vector3 currentMovementV;

	CharacterController controller;
	Vector3 currentMovement;
	public Transform cameraTransform;
	float verticalSpeed;

	public bool isMoving;


	void Awake () 
	{
		instance = this;
	}


	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController>();
		cameraTransform = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 horizontalInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//print (horizontalInput);
		if (horizontalInput.magnitude > 1) 
		{
			horizontalInput.Normalize ();

		}

		if (horizontalInput.magnitude > 0) 
		{
			isMoving = true;
		} else
			isMoving = false;

		Vector3 targetHorizontalMovement = horizontalInput;
		targetHorizontalMovement = cameraTransform.rotation * targetHorizontalMovement;
		targetHorizontalMovement.y = 0;
		targetHorizontalMovement.Normalize();
		targetHorizontalMovement *= horizontalInput.magnitude;
		//currentMovement = targetHorizontalMovement * moveSpeed;
		currentMovement = Vector3.SmoothDamp(currentMovement, targetHorizontalMovement * moveSpeed, ref currentMovementV, moveSpeedSmooth);

		Quaternion targetRotationQ = Quaternion.LookRotation(Vector3.forward);
		if(new Vector3(currentMovement.x,0,currentMovement.z).magnitude > 1)
		{
	 		targetRotationQ = Quaternion.LookRotation(new Vector3(currentMovement.x,0,currentMovement.z));
			//transform.rotation = Quaternion.Lerp(transform.rotation, targetRotationQ, rotateSpeed * Time.deltaTime); 
			transform.rotation = Quaternion.Euler(0, Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, targetRotationQ.eulerAngles.y, ref rotationV, rotateSpeedSmooth),0);
		}


		if (!controller.isGrounded)
			verticalSpeed -= gravity * Time.deltaTime;
		else
			verticalSpeed = 0;

		if (controller.isGrounded && Input.GetButtonDown("Jump"))
			verticalSpeed = jumpSpeed;

		currentMovement.y = verticalSpeed;

		controller.Move(currentMovement * Time.deltaTime);
	}
}
