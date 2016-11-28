using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;

public class MixerControl: Singleton<MixerControl> {

	[SerializeField] AudioMixer mixer;

	public void SetLevelOne (float level) {
		level *= 18.0f;
		mixer.SetFloat ("One", level);
	}
	public void SetLevelTwo (float level) {
		level *= 18.0f;
		mixer.SetFloat ("Two", level);
	}
	public void SetLevelThree (float level) {
		level *= 18.0f;
		mixer.SetFloat ("Three", level);
	}

}
