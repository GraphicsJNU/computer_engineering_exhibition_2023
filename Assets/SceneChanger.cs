using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private static SceneChanger instance = null;
    public static SceneChanger Instance
    {
        get
        {
           
            return instance;
        }
    }

    //5개의 Scene을 1분마다 자동으로 전환하는 코드
    private float time = 0.0f;
    public float sceneChangeTime = 60.0f;
    private int sceneIndex = 0;
    private int sceneCount = 5;

    void Awake()
    {
         if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }else{
                if(instance != this){
                    Destroy(this.gameObject);
                }
            }
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > sceneChangeTime)
        {
            time = 0.0f;
            sceneIndex++;
            if (sceneIndex >= sceneCount)
            {
                sceneIndex = 0;
            }
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
