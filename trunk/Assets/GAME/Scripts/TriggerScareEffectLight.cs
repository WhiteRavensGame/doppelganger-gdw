// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("DOPPELGANGER")]
	[Tooltip("Sets the camera effect of the thing.")]
	public class TriggerScareEffectLight : FsmStateAction
	{
		//[RequiredField]
		//[UIHint(UIHint.Variable)]
		//public FsmOwnerDefault variable;
		//public FsmGameObject gameObject;
		//public bool everyFrame;
		public FsmInt playerHealth;

		public Light playerLight;
		//private GameObject mainCam;
		
		public override void Reset()
		{
			playerHealth = 0;
			//variable = null;
			//gameObject = null;
			//everyFrame = false;
		}
		
		public override void OnEnter()
		{
			//variable.Value = gameObject.Value;

			//mainCam = GameObject.FindGameObjectWithTag ("MainCamera");

			//mainCam.GetComponent<MotionBlur> ().blurAmount = (100 - playerHealth.Value) / 100;
			//mainCam.GetComponent<BlurEffect> ().blurSpread = 1 - (playerHealth.Value / 100); //VOMMIT!
			Debug.Log (playerHealth.Value);
			playerLight.range = (playerHealth.Value / 100) * 8;

			Finish();		
		}

	}
}