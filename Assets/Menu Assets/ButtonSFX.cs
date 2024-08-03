using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour {

	public AudioSource MySFX;
	public AudioClip HoverSFX;
	public AudioClip ClickSFX;

	
	public void HoverSound()
	{
		MySFX.PlayOneShot (HoverSFX);
	}
	public void ClickSound()
	{
		MySFX.PlayOneShot (ClickSFX);
	}

}
