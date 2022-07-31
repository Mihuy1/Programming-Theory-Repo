using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanSetting : PlayerController
{

    // INHERITANCE
    // POLYMORPHISM
    public override void VehicleControl()
    {
        horsePower = 20;
        base.VehicleControl();
    }
}
