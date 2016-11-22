// Audio is recorded first and then video is recorded. When finished recording video, both are mixed into a single video
// This is useful in Replays where audio is recorded during playtime, but video during Replay running slower to grab all frames

#pragma strict

function Start () {
	DelayedPlay();
}

function Update () {
	CaptureControl.recAudio = GetComponent.<AudioSource>().isPlaying;
}

function DelayedPlay(){
	yield WaitForSeconds(1);
	GetComponent.<AudioSource>().Play();
	yield WaitForSeconds(10);
	CaptureControl.recVideo = true;
	yield WaitForSeconds(7);
	CaptureControl.recVideo = false;
}
