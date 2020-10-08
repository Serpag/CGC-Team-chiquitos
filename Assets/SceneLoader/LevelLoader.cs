using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public string nextScene;
    public float timerAuto;

    private void Start()
    {
        if(timerAuto!=0)
            StartCoroutine(delayAuto());
    }


    public void ChageScene(string sceneName)
    {
        StartCoroutine(delay(sceneName));
    }

    IEnumerator delay(string sceneName)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
    }


    IEnumerator delayAuto()
    {
        yield return new WaitForSeconds(timerAuto);
        StartCoroutine(delay(nextScene));
    }
}
