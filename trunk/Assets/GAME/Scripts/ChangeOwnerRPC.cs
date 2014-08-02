using UnityEngine;
using System.Collections;

public class ChangeOwnerRPC : MonoBehaviour {


	/*
	void MakeMeTheNewOwner()
	{
		int newID = PhotonNetwork.AllocateViewID();
		photonView.RPC("SetNewOwner", PhotonTargets.All, newID);       
	}


	[RPC]
	void SetNewOwner(int newID)
	{
		if (photonView.isMine)
		{
			PhotonNetwork.UnAllocateViewID(photonView.viewID); //Recycle this number (we "only" have 1000 views per default)
		}
		photonView.viewID = newID;   
		// TODO: This code works fine if we have a game where no other players can join while a game is in progress.
		// In other games we have a problem: new player joins it will not be notified of the new owner.
		// I think we can't simply buffer the SetNewOwner call as it would be called several times (possibly the wrong order?).
		// Furthermore we do not know if this GO was instantiated manually, using PhotonNetwork.Instantiate or whether it was a scene object.
		//     
	}*/

}
