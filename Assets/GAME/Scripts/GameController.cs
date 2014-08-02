using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private GameObject playerDoppelganger;


	void Start()
	{

	}

	void Update()
	{

	}

	void AssignPlayer1()
	{

	}

	/*
	public GameObject bulletPrefab;
	
	public Transform muzzle;

	void Start ()
	{
		muzzle = transform.Find("Main Camera/GUN/Muzzle");
	}
	
	void Update ()
	{
		if(Input.GetKeyDown("mouse 0"))
		{
			callFire(PhotonTargets.Others);
			if(photonView.isMine)
			{
				instaBullet();
			}
		}
	}
	
	void instaBullet()
	{
		Instantiate(bulletPrefab,muzzle.position,muzzle.rotation);
	}

	[RPC]
	void Fire(PhotonMessageInfo info)
	{
		if(info.sender.ID != PhotonNetwork.player.ID)
		{
			instaBullet();
		}   
	}

	void callFire(PhotonTargets target)
	{
		photonView.RPC("Fire",target);
	}
	*/
}
