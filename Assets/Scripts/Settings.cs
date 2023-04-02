using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject SettingsCanvas;
    public GameObject LanguagesCanvas;
    public GameObject CreditsCanvas;
    public GameObject ControlsCanvas;
    public GameObject LoreCanvas;
    public GameObject FactoryIntroCanvas;
    public GameObject FactoryOutroCanvas;
    public GameObject MusicManager;

    public void PressSettings()
    {
        StartCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void Back()
    {
        StartCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

    public void Languages() 
    {
        LanguagesCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

    public void BackLanguages()
    {
        LanguagesCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void SetCredits()
    {
        SettingsCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
        MusicManager.SetActive(false);
    }

    public void BackCredits()
    {
        CreditsCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
        MusicManager.SetActive(true);
    }

    public void Controls()
    {
        ControlsCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

    public void BackControls()
    {
        ControlsCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void Lore()
    {
        LoreCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

    public void BackLore()
    {
        LoreCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void FactoryIntro()
    {
        FactoryIntroCanvas.SetActive(true);
        LoreCanvas.SetActive(false);
    }

    public void BackFactoryIntro()
    {
        FactoryIntroCanvas.SetActive(false);
        LoreCanvas.SetActive(true);
    }

    public void FactoryOutro()
    {
        FactoryOutroCanvas.SetActive(true);
        LoreCanvas.SetActive(false);
    }

    public void BackFactoryOutro()
    {
        FactoryOutroCanvas.SetActive(false);
        LoreCanvas.SetActive(true);
    }
}
