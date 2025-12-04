using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;

    void Start()
    {
        /* Resolution dropdown */
        Resolution[] resolutions = Screen.resolutions;
        List<TMP_Dropdown.OptionData> data = new List<TMP_Dropdown.OptionData>();

        string currentResolution = Screen.width + "x" + Screen.height;
        int currentResolutionIdx = 0;

        foreach (Resolution res in resolutions)
        {
            string resolution = res.width + "x" + res.height;
            data.Add(new TMP_Dropdown.OptionData(resolution));

            if (resolution == currentResolution)
            {
                currentResolutionIdx = data.Count - 1;
            }
        }

        resolutionDropdown.options = data;
        resolutionDropdown.SetValueWithoutNotify(currentResolutionIdx);

        /* Fullscreen check */
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
