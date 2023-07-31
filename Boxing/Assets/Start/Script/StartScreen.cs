using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartScreen : MonoBehaviour
{
    public RawImage videoDisplay;
    public VideoClip videoClip;

    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.renderMode = VideoRenderMode.RenderTexture;
        videoPlayer.targetTexture = new RenderTexture((int)videoDisplay.rectTransform.rect.width, (int)videoDisplay.rectTransform.rect.height, 0);

        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoClip;
        videoPlayer.isLooping = true;

        videoDisplay.texture = videoPlayer.targetTexture;

        videoPlayer.Play();
    }
}