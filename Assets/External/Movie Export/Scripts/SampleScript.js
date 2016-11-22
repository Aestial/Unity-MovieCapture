// Video and Audio are recorded at the same time

#pragma strict

function Start () {
	GetComponent.<AudioSource>().Play();
}

function Update () {
	CaptureControl.recVideo = GetComponent.<AudioSource>().isPlaying;
	CaptureControl.recAudio = GetComponent.<AudioSource>().isPlaying;
}
