using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public static SceneChange Instance;  // �̱���
    private void Awake()
    {
        Instance = this;
    }
   
    public int nowExerciseIndex { set; get; }   // �� ��ε���

    public float playTime { set; get; }  // � �ð�
    
    public string nowExerciseName(int index)  // � �̸�
    {
        var exerciseDic = new Dictionary<int, string>();  //InteractableToggleCollection���� �޾ƿ� �ε����� �´� �̸� ��ųʸ�
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
    
    public void ChangeSceneFn(string sceneName)  // �� �ٲٱ�
    {
        SceneManager.LoadScene(sceneName);
    }
}
