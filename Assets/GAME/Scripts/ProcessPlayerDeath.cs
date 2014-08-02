// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("DOPPELGANGER")]
	[Tooltip("Turn off Character Controller and 3rd Person Controller Script.")]
	public class ProcessPlayerDeath : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;
		
		public override void Reset()
		{
			gameObject = null;
		}
		
		public override void OnEnter()
		{
			DoGetTag();

			Finish();
		}

		
		void DoGetTag()
		{
			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null) return;

			go.GetComponentInChildren<Light>().enabled = false;
			go.GetComponent<ThirdPersonController> ().enabled = false;
			go.GetComponent<CharacterController> ().enabled = false;
		}
		
	}
}