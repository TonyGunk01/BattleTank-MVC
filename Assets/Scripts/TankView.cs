using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;

    public Rigidbody rb;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, 30);

        if (rotation != 0)
            tankController.Rotate(rotation, 20);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void setTankController(TankController tank_controller)
    {
        tankController = tank_controller;
    }

    public Rigidbody getRigidbody()
    {
        return rb;
    }
}
