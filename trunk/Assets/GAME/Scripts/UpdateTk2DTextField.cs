// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("TK2D")]
	[Tooltip("Sets the Text used by the GUIText Component attached to a Game Object.")]
	public class UpdateTk2dTextField : FsmStateAction
	{
		//[RequiredField]
		//[CheckForComponent(typeof(GUIText))]
		//public FsmOwnerDefault gameObject;
		//public FsmString text;
		//public bool everyFrame;
		
		public tk2dUITextInput textInput;
		public FsmString newText;
		
		public override void Reset()
		{
			textInput = null;
			newText = null;
		}
		
		public override void OnEnter()
		{
			//DoSetGUIText();
			textInput.Text = newText.Value;
			//textInput.text = newText.Value;
			//textInput.Commit ();
			
		}
		
		//public override void OnUpdate()
		//{
		//	DoSetGUIText();
		//}
		
		//void DoSetGUIText()
		//{
		//	GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
		//	if (go != null && go.guiText != null)
		//		go.guiText.text = text.Value;
		//}
	}
}