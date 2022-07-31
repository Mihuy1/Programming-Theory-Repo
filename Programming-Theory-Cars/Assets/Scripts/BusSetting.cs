using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusSetting : PlayerController
{

    public override void VehicleControl()
    {
        horsePower = 30;
        base.VehicleControl();
    }
}
