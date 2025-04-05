using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject settingsPanel;
   public void PlayClick()
    {
        SceneManager.LoadScene(1);
    }
    public void SettingsClick()
    {
        settingsPanel.SetActive(true);
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}
