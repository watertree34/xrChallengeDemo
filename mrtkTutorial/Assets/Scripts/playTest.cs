using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� �� �: " + SceneChange.Instance.nowExerciseIndex);   
    }

    public void OnclickFinish()
    {
        SceneChange.Instance.ChangeSceneFn("ResultScene");
    }
}
