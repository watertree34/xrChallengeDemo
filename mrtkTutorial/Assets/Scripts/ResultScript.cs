using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResultScript : MonoBehaviour
{
    public GameObject name;
    public GameObject time;
    public GameObject cal;

    private void Start()
    {
        name.GetComponent<TextMesh>().text=SceneChange.Instance.nowExerciseName(SceneChange.Instance.nowExerciseIndex);
        time.GetComponent<TextMesh>().text = Mathf.Round(SceneChange.Instance.playTime).ToString() + " 초";
        cal.GetComponent<TextMesh>().text = Mathf.Round(SceneChange.Instance.playTime*0.57f).ToString() + " kcal";  // 임의로 설정
    }

    public void HomeBtn()
    {
        SceneChange.Instance.ChangeSceneFn("SelectScene");
    }

}
