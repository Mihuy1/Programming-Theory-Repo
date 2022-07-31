using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSetting : PlayerController
{

    public override void VehicleControl()
    {
        horsePower = 25;
        base.VehicleControl();
    }
}
