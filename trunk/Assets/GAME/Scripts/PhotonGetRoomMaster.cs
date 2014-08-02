// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Photon")]
	[Tooltip("Get the master of the room.")]
	//[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W905")]
	public class PhotonGetRoomMaster : FsmStateAction
	{
		[Tooltip("Send this event if the player is the master.")]
		public FsmEvent playerIsMasterEvent;
		
		[Tooltip("Send this event if the player is NOT the master.")]
		public FsmEvent playerIsNotMasterEvent;
		
		public override void Reset()
		{
			playerIsMasterEvent = null;
			playerIsNotMasterEvent = null;
			//PhotonNetwork.playerList[2].isMasterClient
		}
		
		public override void OnEnter()
		{
			if(PhotonNetwork.player.isMasterClient)
			{
				Fsm.Event(playerIsMasterEvent);
			}
			else
			{
				Fsm.Event(playerIsNotMasterEvent);
			}

			Finish();
		}

		
	}
}