using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTest : MonoBehaviour
{
    bool play;
    
    void Start()
    {
        Debug.Log("오늘 할 운동: " + SceneChange.Instance.nowExerciseIndex);
        play = true;
        StartCoroutine("Timer");
    }
    IEnumerator Timer()  // 플레이시간
    {
        while (play)
        {
            SceneChange.Instance.playTime += Time.deltaTime;
            yield return null;
        }
    }
    public void OnclickFinish()
    {
        play = false;
        SceneChange.Instance.ChangeSceneFn("ResultScene");
    }
}
