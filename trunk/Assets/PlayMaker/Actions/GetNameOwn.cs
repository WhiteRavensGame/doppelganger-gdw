// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the name of a Game Object and stores it in a String Variable.")]
	public class GetNameOwn : FsmStateAction
	{
		[RequiredField]
		//public FsmGameObject gameObject;
		public FsmOwnerDefault gameObject;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeName;
		
		public bool everyFrame;

		public override void Reset()
		{
			//gameObject = new FsmGameObject { UseVariable = true};
			gameObject = null;
			storeName = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoGetGameObjectName();
			
			if (!everyFrame)
			{
				Finish();
			}
		}
		
		public override void OnUpdate()
		{
			DoGetGameObjectName();
		}
		
		void DoGetGameObjectName()
		{
			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null) return;

			//var go = gameObject.Value;

			storeName.Value = go != null ? go.name : "";
		}
	}
}