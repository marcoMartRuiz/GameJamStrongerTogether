using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayMode");
    }

    public void ExitGame()
    {
        Debug.Log("I QUIT!");
        Application.Quit();
    }

    public void GoBack()
    {

    }


}

