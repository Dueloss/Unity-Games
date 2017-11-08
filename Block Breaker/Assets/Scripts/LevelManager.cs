using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string Name)
    {
        Debug.Log(Name);
        SceneManager.LoadScene(Name);
    }

    public void QuitRequest()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
