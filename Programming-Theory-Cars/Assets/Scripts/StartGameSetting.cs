using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartGameSetting : MonoBehaviour
{
    public TMP_InputField yearInputField;
    public GameObject Panel;

    public GameObject playerCar;
    public GameObject playerBus;
    public GameObject playerVan;

    public Button Car;
    public Button Bus;
    public Button Van;

    public string yearOfVehicle;


    public void ReadStringInput()
    {
        yearOfVehicle = yearInputField.text;
        Debug.Log(yearOfVehicle);
    }

    public void StartGame()
    {
        Panel.SetActive(false);
    }

    // ABSTRACTION
    public void SetCar(bool car)
    {
        playerCar.SetActive(true);
        playerBus.SetActive(false);
        playerVan.SetActive(false);

        car = true;
    }

    public void SetBus(bool bus)
    {
        playerBus.SetActive(true);
        playerCar.SetActive(false);
        playerVan.SetActive(false);

        bus = true;
    }

    public void SetVan(bool van)
    {
        playerVan.SetActive(true);
        playerCar.SetActive(false);
        playerBus.SetActive(false);

        van = true;
    }


}
