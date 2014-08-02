using UnityEngine;
using System.Collections;

public class footsteps : MonoBehaviour {
	
	public AudioSource a;

	public AudioClip footstep1;
	public AudioClip footstep2;

	private CharacterController controller;
	
	private float footstepTime;
	public float footstepTimeInit;

	private bool leftStep = true;
	
	void Start()
	{
		controller = gameObject.GetComponent< CharacterController >();

		footstepTime = footstepTimeInit;
	}
	
	void Update()
	{
		if( controller.velocity.magnitude > 0.2f && !a.isPlaying && footstepTime <= 0f )
		{
			if(leftStep)
			{
				a.PlayOneShot(footstep1);
			}
			else
			{
				a.PlayOneShot (footstep2);
			}

			footstepTime = footstepTimeInit;
			if(controller.velocity.magnitude > 4.2f)
			{
				footstepTime = footstepTime * 0.67f;
			}
			leftStep = !leftStep;

		}

		//Debug.Log(controller.velocity.magnitude); //run
		footstepTime -= Time.fixedDeltaTime;
	}
}
