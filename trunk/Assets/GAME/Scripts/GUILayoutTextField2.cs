// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("DOPPELGANGER")]
	[Tooltip("GUILayout Text Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutTextField2 : GUILayoutAction
	{
		[UIHint(UIHint.Variable)]
		public FsmString text;
		public FsmInt maxLength;
		public FsmString style;
		public FsmEvent changedEvent;

		public FsmBool typingMode;

		private bool lagBlock = false;

		public override void Reset()
		{
			base.Reset();
			text = null;
			maxLength = 25;
			style = "TextField";
			changedEvent = null;

			typingMode = true;

		}
		
		public override void OnGUI()
		{
			//if (Event.current.isKey && Event.current.keyCode == KeyCode.Return) 


			var guiChanged = GUI.changed;
			GUI.changed = false;

			GUI.SetNextControlName("Chat");
			//if (Event.current.type == EventType.KeyDown && (Event.current.keyCode == KeyCode.Enter || Event.current.keyCode == KeyCode.Return))
			//{
			//	Debug.Log("BLEH BLHE BLEH");
			//}

			//if(Input.GetKeyDown (KeyCode.Return) && typingMode.Value && text.Value != "" && lagBlock)
			if(Input.GetKeyDown (KeyCode.Return))
			{
				Debug.Log("KEY DOWN!");
				if(typingMode.Value)
				{
					Debug.Log("22" + typingMode.Value);
				}
				if(text.Value != "")
				{
					Debug.Log("33" + text.Value);
				}
				Debug.Log(typingMode.Value + "," + text.Value);
				Debug.Log("Send whatever you typed");
				typingMode = false;
				//Fsm.BroadcastEvent("SEND TO ALL");
				Debug.Log ("1" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
				lagBlock = false;
			
			}

			else if(Input.GetKeyDown (KeyCode.Return) && typingMode.Value && text.Value == "" && lagBlock)
			{
				Debug.Log("Deselect field.");
				GUI.FocusControl("");
				typingMode = false;
				Debug.Log ("1.5" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
				lagBlock = false;
			}
			else if(Input.GetKeyDown (KeyCode.Return) && !typingMode.Value && lagBlock)
			{
				Debug.Log("Begin typing mode");
				GUI.FocusControl("Chat");
				typingMode = true;
				Debug.Log ("2" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
				lagBlock = false;
			}
			else if(!lagBlock)
			{
				lagBlock = true;
				//Fsm.Variables.GetVariable("");
			}
			else
			{
				//text.Value = GUILayout.TextField(text.Value, maxLength.Value, style.Value, LayoutOptions);
				text.Value = GUI.TextField(new Rect(10, 10, 100, 20), text.Value);
				//Debug.Log ("3" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
			}



			if (GUI.changed)
			{
				Fsm.Event(changedEvent);
				GUIUtility.ExitGUI();
				//Debug.Log ("4" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
			}
			else
			{
				GUI.changed = guiChanged;
				//Debug.Log ("5" + Input.GetKeyDown (KeyCode.Return) + "," + typingMode.Value);
			}
		}
	}
}