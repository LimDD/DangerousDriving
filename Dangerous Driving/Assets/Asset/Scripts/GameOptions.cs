using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOptions : MonoBehaviour
{
    [SerializeField] GameObject DropdownSettings;
    [SerializeField] GameObject LevelOfDifficulty;
    [SerializeField] GameObject volumeObject;

    Dropdown qualitySettings;
    Slider volumeSlider;
    // TODO: Difficulty setting member


    // Start is called before the first frame update
    void Start()
    {
        SetQualitySettings();
        SetVolumeSettings();
    }

    void SetVolumeSettings()
    {
        volumeSlider = volumeObject.GetComponent<Slider>();
        float volume = volumeSlider.value;
    }

    void SetQualitySettings()
    {
        // Set quality settings
        qualitySettings = DropdownSettings.GetComponent<Dropdown>();
        int qualityIndex = qualitySettings.value; // 5 - Very low, 4 - Low, 3 - Medium, 2 - High, 1 - Very High, 0 - Ultra

        QualitySettings.SetQualityLevel(qualityIndex); // Set the quality level to qualityIndex
        DontDestroyOnLoad(gameObject); // Don't let unity destroy this gameobject the script is attached to
        qualitySettings.onValueChanged.AddListener(onQualityChanged); // Add listener when setting is changed
    }

    void onQualityChanged(int value)
    {
        QualitySettings.SetQualityLevel(value); // Set the quality level to value
    }
}
