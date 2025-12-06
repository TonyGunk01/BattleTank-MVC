using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float movement_speed, float rotation_speed)
    {
        movementSpeed = movement_speed;
        rotationSpeed = rotation_speed;
    }

    public void setTankController(TankController tank_controller)
    {
        tankController = tank_controller;
    }
}