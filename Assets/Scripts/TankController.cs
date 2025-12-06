using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel tank_model, TankView tank_view)
    {
        tankModel = tank_model;
        tankView = GameObject.Instantiate<TankView>(tank_view);

        rb = tankView.getRigidbody();

        tankModel.setTankController(this);
        tankView.setTankController(this);
    }

    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel getTankModel()
    {
        return tankModel;
    }
}