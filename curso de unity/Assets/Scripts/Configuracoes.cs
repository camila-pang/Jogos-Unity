using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracoes : MonoBehaviour
{
    public bool isFullscreen;
    public int resolutionIndex;
    public int qualityTexture;
    public float musicVolume;


    public Toggle isFullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown qualityTextureDropDown;
    public Slider musicVolumeSlider;

    public Resolution[] resolutions;


    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        foreach(Resolution reso in resolutions) 
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(reso.ToString()));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
