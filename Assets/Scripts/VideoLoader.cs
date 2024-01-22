/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoLoader : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string videoUrl;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {

    }
}*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoLoader : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        VideoPlayer vPlayer = gameObject.AddComponent<VideoPlayer>();
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        // IMPORTANT, cf la doc
        vPlayer.playOnAwake = false;
        audio.playOnAwake = false;

        vPlayer.url = "https://www.youtube.com/watch?v=jfKfPfyJRdk";
        vPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        vPlayer.targetCamera = Camera.main;

        vPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        vPlayer.controlledAudioTrackCount = 1;
        vPlayer.EnableAudioTrack(0, true);
        vPlayer.SetTargetAudioSource(0, audio);

        vPlayer.prepareCompleted += Prepared;
        vPlayer.Prepare();
    }

    void Prepared(VideoPlayer vPlayer)
    {
        Debug.Log("End reached!");
        vPlayer.Play();
    }
}
