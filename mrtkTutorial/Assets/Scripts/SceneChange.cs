using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public static SceneChange Instance;  // 싱글톤
    private void Awake()
    {
        Instance = this;
    }
   
    public int nowExerciseIndex { set; get; }   // 할 운동인덱스

    public float playTime { set; get; }  // 운동 시간
    
    public string nowExerciseName(int index)  // 운동 이름
    {
        var exerciseDic = new Dictionary<int, string>();  //InteractableToggleCollection에서 받아온 인덱스에 맞는 이름 딕셔너리
        exerciseDic.Add(0, "Squat");
        exerciseDic.Add(1, "Burpee Test");
        exerciseDic.Add(2, "Stretching");

        string result = exerciseDic[index];
        return result;
    }
    private void Start()
    {
        DontDestroyOnLoad(this);
        nowExerciseIndex = -1;
        playTime = 0;

       
    }
    
    public void ChangeSceneFn(string sceneName)  // 씬 바꾸기
    {
        SceneManager.LoadScene(sceneName);
    }
}
