using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void BtnStartGame(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void BtnQuit()
    {
        Application.Quit();
    }
}
