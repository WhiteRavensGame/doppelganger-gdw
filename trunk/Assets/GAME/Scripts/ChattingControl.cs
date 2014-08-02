using UnityEngine;
using System.Collections;

public class ChattingControl : MonoBehaviour {

	public string chatMsg = "";

	private bool chatWindowOpened = false;

	public PlayMakerFSM theFSM;

	public tk2dTextMesh chatLogText;
	public tk2dUITextInput chatMsg2;

	void Start()
	{
		chatMsg = GUI.TextField(new Rect(910, 910, 100, 20), chatMsg);
		chatMsg2.gameObject.SetActive (false);
	}

	void OnGUI() {

		//hide chat if you're muted
		//if (theFSM.FsmVariables.GetFsmBool ("isMuted").Value == true)
		//{
		//	chatWindowOpened = false;
		//	return;
		//}

		GUI.SetNextControlName("Chat");
		GUI.FocusControl("Chat");

		//chatMsg2.SetFocus (true);

		if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
		{
			if(!chatWindowOpened) // open the chat window
			{
				chatWindowOpened = true;
			}
			else // send and close the chat window
			{
				//if(chatMsg != "")
				if(chatMsg2.Text.ToString() != "")
				{
					//Debug.Log("Display: " + chatMsg);
					Debug.Log("Display: " + chatMsg2.Text);

					if (theFSM.FsmVariables.GetFsmBool ("isMuted").Value == false)
					{
						theFSM.FsmVariables.GetFsmString("chat text input").Value = chatMsg2.Text;
						theFSM.Fsm.BroadcastEvent("typed");
					}
				}

				//clear and then close window
				chatMsg = GUI.TextField(new Rect(15, 560, 590, 32), "");
				chatMsg2.Text = "";
				chatMsg2.SetFocus(false);
				chatMsg2.gameObject.SetActive (false);
				chatWindowOpened = false;
			}

		}

		if(chatWindowOpened)
		{
			chatMsg = GUI.TextField(new Rect(915, 960, 590, 32), chatMsg);
			chatMsg2.gameObject.SetActive (true);
			chatMsg2.SetFocus (true);
			//pwd = GUI.TextField(new Rect(10, 40, 100, 20), pwd);
		}

		//when pressing enter, send message AND close message.
	}
}
