using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;   //InteractableToggleCollection�ǵ帮��x // �ε��� �޾ƿ������� package���� ���ӽ����̽� ������

public class SelectStartBtn : MonoBehaviour
{
    InteractableToggleCollection Toggle;

    private void Start()
    {
        Toggle = GetComponentInParent<InteractableToggleCollection>();
    }
    public void OnClickStart()
    {
        
        if (Toggle.CurrentIndex < 0) // � ���� ���������
            return;
        else    // �������� ���
        {
            SceneChange.Instance.nowExerciseIndex = Toggle.CurrentIndex;  // ���߿� � ���� �ε����� ����� ����
            SceneChange.Instance.ChangeSceneFn("Play");  // ����ȯ
        }
    }
   
}
