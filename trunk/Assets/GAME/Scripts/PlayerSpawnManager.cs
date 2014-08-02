// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("DOPPELGANGER")]
	[Tooltip("Return the correct spawn point.")]
	//[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W905")]
	public class PlayerSpawnManager : FsmStateAction
	{
		//[Tooltip("Send this event if the player is the master.")]
		//public FsmEvent playerIsMasterEvent;
		
		//[Tooltip("Send this event if the player is NOT the master.")]
		//public FsmEvent playerIsNotMasterEvent;

		[Tooltip("The passed string")]
		public FsmString stringPassed;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Vector3 variable.")]
		public FsmVector3 vector3Variable;

		private GameObject[] spawnPoints;

		public override void Reset()
		{
			stringPassed = null;
			vector3Variable = null;

			//playerIsMasterEvent = null;
			//playerIsNotMasterEvent = null;
			//PhotonNetwork.playerList[2].isMasterClient
		}



		public override void OnEnter()
		{
			spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
			Debug.Log ("Spawn points found: " + spawnPoints.Length);

			int locIndex = int.Parse(stringPassed.Value);
			locIndex = locIndex % spawnPoints.Length;

			vector3Variable.Value = spawnPoints [locIndex].transform.position;

			//TODO: Do raycast to see if there's obstruction. Don't spawn if there is.


			/*
			if(PhotonNetwork.player.isMasterClient)
			{
				Fsm.Event(playerIsMasterEvent);
			}
			else
			{
				Fsm.Event(playerIsNotMasterEvent);
			}
			*/
			
			Finish();
		}
		
		
	}
}