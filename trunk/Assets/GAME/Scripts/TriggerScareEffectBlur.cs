// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("DOPPELGANGER")]
	[Tooltip("Sets the camera effect of the thing.")]
	public class TriggerScareEffectBlur : FsmStateAction
	{
		//[RequiredField]
		//[UIHint(UIHint.Variable)]
		//public FsmOwnerDefault variable;
		//public FsmGameObject gameObject;
		//public bool everyFrame;
		//public FsmInt playerHealth;

		//public Light playerLight;
		private GameObject mainCam;

		public FsmBool toBlur;
		
		public override void Reset()
		{
			toBlur = null;
			//playerHealth = 0;
			//variable = null;
			//gameObject = null;
			//everyFrame = false;
		}
		
		public override void OnEnter()
		{
			//variable.Value = gameObject.Value;
			//Debug.Log (playerHealth.Value);
			mainCam = GameObject.FindGameObjectWithTag ("MainCamera");

			mainCam.GetComponent<MotionBlur> ().enabled = toBlur.Value;

			//if(toBlur.Value)
				//mainCam.GetComponent<BlurEffect> ().blurSpread = 0.8f;
				//mainCam.GetComponent<BlurEffect> ().blurSpread = 0.8f;
			//else
			//	mainCam.GetComponent<BlurEffect> ().blurSpread = 0.0f;
				//mainCam.GetComponent<MotionBlur> ().enabled = toBlur.Value;
			//mainCam.GetComponent<BlurEffect> ().blurSpread = 1 - (playerHealth.Value / 100); //VOMMIT!

			//playerLight.range = (playerHealth.Value / 100) * 8;

			Finish();		
		}

	}
}