using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankType;
    public Material tankColor;

    public TankModel(float movement_speed, float rotation_speed, TankTypes tank_type, Material tank_color)
    {
        movementSpeed = movement_speed;
        rotationSpeed = rotation_speed;
        tankType = tank_type;
        tankColor = tank_color;
    }

    public void setTankController(TankController tank_controller)
    {
        tankController = tank_controller;
    }
}