using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTest : MonoBehaviour
{
    bool play;
    
    void Start()
    {
        Debug.Log("���� �� �: " + SceneChange.Instance.nowExerciseIndex);
        play = true;
        StartCoroutine("Timer");
    }
    IEnumerator Timer()  // �÷��̽ð�
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
