using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public RawImage videoDisplay;
    public VideoClip videoClip;

    private VideoPlayer videoPlayer;
    private RenderTexture renderTexture;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoClip;

        renderTexture = new RenderTexture(1920, 1080, 0);
        videoPlayer.targetTexture = renderTexture;

        videoDisplay.texture = renderTexture;

        videoPlayer.Play();
    }
}

