using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadIntranetTour()
    {
        SceneManager.LoadScene("IntranetTourScene");
    }

    public void LoadCustomCampusTour()
    {
        SceneManager.LoadScene("CustomCampusTourScene");
    }
}