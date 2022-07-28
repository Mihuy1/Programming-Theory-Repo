using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartGameSetting : MonoBehaviour
{
    public TMP_InputField carYear;
    public GameObject Panel;

    public string yearInputField;
    public string vehicleInputField;

    public void Start()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }


}
