using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueButtonManager : MonoBehaviour
{
    [SerializeField] private string gameSceneName; 
    public void StartGame()
    {
        Debug.Log($"{Pressed("New Game")}");
        SceneManager.LoadScene(gameSceneName);
    }
    public void LoadGame()
    {
        Debug.Log($"{Pressed("Load Game")}");
    }
    public void Option()
    {
        var text = Pressed("Options");
        Debug.Log(text);
    }
    public void QuitGame()
    {
        Debug.Log($"{Pressed("Quit Game")}");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    private string Pressed(string button)
    {
        return button + " Button Pressed";
    }
}
