using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWebCamTexture : MonoBehaviour
{
    [Header("�̿��� ī�޶� (default = 0)")]
    public int DeviceIndex = 0;

    [Header("ī�޶� �ػ󵵿� ������ ����")]
    public int width = 1920;
    public int height = 1080;
    public int fps = 60;

    [Header("ī�޶�κ��� �ؽ��ĸ� �޾� ������ Render Texture")]
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
