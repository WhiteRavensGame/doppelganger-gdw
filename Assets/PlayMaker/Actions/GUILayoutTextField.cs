// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Text Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutTextField : GUILayoutAction
	{
		[UIHint(UIHint.Variable)]
		public FsmString text;
		public FsmInt maxLength;
		public FsmString style;
		public FsmEvent changedEvent;

		//public FsmBool typingMode;

		public override void Reset()
		{
			base.Reset();
			text = null;
			maxLength = 25;
			style = "TextField";
			changedEvent = null;

			//typingMode = false;

		}
		
		public override void OnGUI()
		{
			//if (Event.current.isKey && Event.current.keyCode == KeyCode.Return) 


			var guiChanged = GUI.changed;
			GUI.changed = false;

			//NEW - enter sends it to event.
			//Event e = Event.current;

			//if (e.keyCode == KeyCode.Return) userHasHitReturn = true;
			
			//else if (false == userHasHitReturn)     stringToEdit = GUI.TextField(new Rect(0,0,100,50), stringToEdit, 25);


			//if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.Enter || Event.current.keyCode == KeyCode.Return))
			//{
			//	Debug.Log("BLEH BLHE BLEH");
			//}

			if(Input.GetKeyDown (KeyCode.Return))
			{
				return;
			}
			else
			{
				text.Value = GUILayout.TextField(text.Value, maxLength.Value, style.Value, LayoutOptions);
			}

			if (GUI.changed)
			{
				Fsm.Event(changedEvent);
				GUIUtility.ExitGUI();
			}
			else
			{
				GUI.changed = guiChanged;
			}
		}
	}
}