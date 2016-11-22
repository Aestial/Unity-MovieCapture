using UnityEngine;
using System.Collections;
using System.IO;

public class ProcessManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Show screen dimensions
		Debug.Log ("Width :" + Screen.width.ToString() + ". Height :" + Screen.height.ToString());

		// Terminal process
		var process = new System.Diagnostics.Process {
			StartInfo = new System.Diagnostics.ProcessStartInfo {
				//FileName = "open",
				//FileName = "/Applications/ffmpeg",
				//FileName = "python",
				FileName = "/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal",
				//Arguments = "--args ./ffmpeg -i SampleMovie.avi Output.mp4",
				//Arguments = "/Users/jaimito/Desktop/ffmpeg -i /Users/jaimito/Desktop/SampleMovie.avi /Users/jaimito/Desktop/Output.mp4",
				//Arguments = "-i /Users/jaimito/Desktop/SampleMovie.avi -o /Users/jaimito/Desktop/Output.mp4",
				//Arguments = "-a /Applications/Utilities/Terminal.app/Contents/MacOS/Terminal -n --args /Applications/ffmpeg -i /Users/jaimito/Desktop/SampleMovie.avi -o /Users/jaimito/Desktop/Output.mp4",
				//Arguments = "-i /Users/jaimito/Desktop/SampleMovie.avi -o /Users/jaimito/Desktop/Output.mp4",
				//Arguments = "-a /Applications/Utilities/Terminal.app/Contents/MacOS/Terminal -n --args /Applications/ffmpeg -i /Users/jaimito/Desktop/SampleMovie.avi -o /Users/jaimito/Desktop/Output.mp4",
				Arguments = "python /Users/jaimito/Desktop/TwitterPost.py",
				UseShellExecute = false,
				RedirectStandardOutput = false,
				CreateNoWindow = false,
			}
		};
		// Start terminal process
		process.Start();
		/*
		// Show result output
		while (!process.StandardOutput.EndOfStream) {
			string line = process.StandardOutput.ReadLine();
			Debug.Log (line);
		}
		/*
		FileInfo info = new FileInfo ("/Users/jaimito/Desktop/ffmpeg");
		System.Diagnostics.Process.Start (info.FullName);
		*/
	}

	// Update is called once per frame
	void Update () {

	}
}
