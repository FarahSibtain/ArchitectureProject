using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void LoadGetStartedScene()
    {
        SceneManager.LoadScene("GetStarted");
    }

    public void LoadARExperienceScene()
    {
        SceneManager.LoadScene("ARExperience");
    }

    public void LoadStartARScene()
    {
        SceneManager.LoadScene("StartAR");
    }
    
    public void LoadImageTrackingExtendedScene()
    {
        SceneManager.LoadScene("ImageTrackingExtended");
    }

    public void LoadImageTrackingExtendedMultipleScene()
    {
        SceneManager.LoadScene("ImageTrackingExtendedMultiple");
    }
}
