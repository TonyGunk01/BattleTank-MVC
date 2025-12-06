using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public TankModel()
    {

    }

    public void setTankController(TankController tank_controller)
    {
        tankController = tank_controller;
    }
}