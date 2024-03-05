using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsMenu;
    public TMP_Dropdown resolutionDropDown;
    Resolution[] resolutions;


    void Start()
    {
        settingsMenu.SetActive(false);
        GetResolutions();
        menu.SetActive(false);
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("application has quit");
    }
    public void GetResolutions()
    {
        resolutions = Screen.resolutions;
        resolutionDropDown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIndex;
        resolutionDropDown.RefreshShownValue();
    }
    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void Resume()
    {
        menu.SetActive(false);
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void Back()
    {
        settingsMenu.SetActive(false);
        menu.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         menu.SetActive(true);
        }
    }
}
