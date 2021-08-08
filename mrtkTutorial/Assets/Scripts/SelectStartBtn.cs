using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;   //InteractableToggleCollection건드리면x // 인덱스 받아오기위해 package에서 네임스페이스 가져옴

public class SelectStartBtn : MonoBehaviour
{
    InteractableToggleCollection Toggle;

    private void Start()
    {
        Toggle = GetComponentInParent<InteractableToggleCollection>();
    }
    public void OnClickStart()
    {
        
        if (Toggle.CurrentIndex < 0) // 운동 선택 안했을경우
            return;
        else    // 선택했을 경우
        {
            SceneChange.Instance.nowExerciseIndex = Toggle.CurrentIndex;  // 나중에 운동 종류 인덱스로 사용할 숫자
            SceneChange.Instance.ChangeSceneFn("Play");  // 씬전환
        }
    }
   
}
