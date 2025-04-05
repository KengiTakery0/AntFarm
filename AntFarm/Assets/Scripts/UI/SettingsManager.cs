using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ResolutionText;

    List<Resolution> resolutions;

    int curResolutionIndex;
    bool fullScreen;

    private void SetResolutionText()
    {
        ResolutionText.text = $"{resolutions[curResolutionIndex].width}x{resolutions[curResolutionIndex].height}";
    }
    private void Start()
    {
        resolutions = Screen.resolutions.ToList();
        curResolutionIndex = 0;
        fullScreen = true;
        SetResolutionText();
    }


    public void NextResolution()
    {
        if(curResolutionIndex < resolutions.Count-1)
        {
            SetResolutionText();
            curResolutionIndex++; 
        }
    }
    public void SetFullScreen()
    {
        fullScreen = !fullScreen;
    }

    public void PrevResolution()
    {
        if(curResolutionIndex>0) 
        {
            SetResolutionText();
            curResolutionIndex--; 
        }
    }

    public void ApplySettings()
    {
        Screen.SetResolution(resolutions[curResolutionIndex].width, resolutions[curResolutionIndex].height, fullScreen);
    }
}
