using UnityEngine;
using System.Collections;

public class SwitchParticleController : MonoBehaviour {

	[SerializeField]
	private ParticleSystem inactiveParticle;
	[SerializeField]
	private ParticleSystem activeParticle;
	[SerializeField]
	private ParticleSystem activeParticleLaser;

	//private int inactiveParticleEmissionRate;
	//private int activeParticleEmissionRate;
	//private int laserEmissionRate;

	// Use this for initialization
	void Start () {
		//inactiveParticleEmissionRate = inactiveParticle.emissionRate;
		//activeParticleEmissionRate = activeParticle.emissionRate;
		//laserEmissionRate = activeParticleLaser.emissionRate;

		activeParticle.enableEmission = false;
		activeParticleLaser.enableEmission = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DisplayActiveParticle()
	{
		activeParticleLaser.enableEmission = true;
		activeParticle.enableEmission = true;
		inactiveParticle.enableEmission = false;
	}

	void DisplayInactiveParticle()
	{
		activeParticleLaser.enableEmission = false;
		activeParticle.enableEmission = false;
		inactiveParticle.enableEmission = true;
	}

}

