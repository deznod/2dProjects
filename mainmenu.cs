using UnityEngine.SceneManagement;
using UnityEngine;

public class mainmenu : MonoBehaviour {

    public void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
