using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel tank_model, TankView tank_view)
    {
        tankModel = tank_model;
        tankView = tank_view;

        tankModel.setTankController(this);
        tankView.setTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}