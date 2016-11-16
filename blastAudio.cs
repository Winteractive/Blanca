using UnityEngine;
using System.Collections;

public class blastAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("oldSamComplaining", this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
