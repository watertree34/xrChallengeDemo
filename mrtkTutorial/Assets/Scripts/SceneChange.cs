using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static SceneChange Instance;
    private void Awake()
    {
        Instance = this;
    }
   
    public int nowExerciseIndex
    {
        set;
        get;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
        nowExerciseIndex = -1;
    }
    
    public void ChangeSceneFn(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
