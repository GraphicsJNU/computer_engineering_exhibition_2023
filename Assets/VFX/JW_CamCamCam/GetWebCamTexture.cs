using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWebCamTexture : MonoBehaviour
{
    [Header("이용할 카메라 (default = 0)")]
    public int DeviceIndex = 0;

    [Header("카메라 해상도와 프레임 설정")]
    public int width = 1920;
    public int height = 1080;
    public int fps = 60;

    [Header("카메라로부터 텍스쳐를 받아 저장할 Render Texture")]
    public RenderTexture renderTexture;

    WebCamTexture webcamTexture;
    void SetWebCamTexture(int index)
    {
        if (webcamTexture != null && webcamTexture.isPlaying)webcamTexture.Stop();
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[index].name, this.width, this.height, this.fps);
        webcamTexture.Play();
    }
    public void Start()
    {
        SetWebCamTexture(DeviceIndex);
        if (renderTexture == null)
        {
            Debug.LogError("renderTexture == null");
            return;
        }
    }
    public void Update()
    {
        Graphics.Blit(webcamTexture, renderTexture);
    }
}
