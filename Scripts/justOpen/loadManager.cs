using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class loadManager : MonoBehaviour
{
    public static loadManager instance;
    public GameObject loadScreen;
    public Slider slider;//进度条
    public Text text;//显示百分比
    public Animator animator;

    private void Awake()
    {
        instance = this;
    }
    public void LoadGuochang()
    {
        StartCoroutine(Loadlevel("guochang"));
    }
    public void LoadPlaying()
    {
        StartCoroutine(Loadlevel("playing"));
    }
    IEnumerator Loadlevel(string str)
    {
        animator.SetBool("Fadein",true);
        animator.SetBool("Fadeout",false);
        yield return new WaitForSeconds(1);

        loadScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(str);
        operation.allowSceneActivation = false;//场景加载完成不激活

        while(!operation.isDone)
        {
            float tempTime = Time.deltaTime / 3;
            slider.value += tempTime;
            text.text = slider.value * 100 + "%";


            if(slider.value >= 0.9f)
            {

                slider.value = 1;
                text.text = "按下任意按键继续";

                if(Input.anyKeyDown)
                {
                    loadScreen.SetActive(false);
                    operation.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}
