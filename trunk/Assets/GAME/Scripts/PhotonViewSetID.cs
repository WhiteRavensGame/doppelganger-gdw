// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Photon")]
	[Tooltip("Set the photon ID Photon network View is controlled by a GameObject. \n A PhotonView component is required on the gameObject")]
	//[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W917")]
	public class PhotonViewSetID : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(PhotonView))]
		[Tooltip("The Game Object with the PhotonView attached.")]
		public FsmOwnerDefault gameObject;
		
		[UIHint(UIHint.Variable)]
		[Tooltip("The PhotonView ID as int")]
		public FsmInt ID;

		[UIHint(UIHint.Variable)]
		[Tooltip("BRUTE FORCE: Just increase by increments 1000 depending on who owns it.")]
		public FsmInt playerNumber;
		
		//[UIHint(UIHint.Variable)]
		//[Tooltip("The PhotonView ID as string")]
		//public FsmString IDAsString;
		
		private PhotonView _networkView;
		
		private void _getNetworkView()
		{
			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null) 
			{
				return;
			}
			
			_networkView =  go.GetComponent<PhotonView>();
		}
		
		public override void Reset()
		{
			gameObject = null;
			ID = null;
			playerNumber = null;
		}
		
		public override void OnEnter()
		{
			//_getNetworkView();

			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null) 
			{
				return;
			}

			//BRUTE FORCE!
			Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<PhotonView>().viewID += playerNumber.Value * 1000;

			//Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<PhotonView>().viewID = ID.Value;

			//go.GetComponent<PhotonView>().
			//ID.Value = _networkView.viewID;
			//IDAsString.Value = _networkView.viewID.ToString();
			//playerNumber.Value
			
			Finish();
		}
		
	}
}