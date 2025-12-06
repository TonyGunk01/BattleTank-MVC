using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public void BlueTankSelected()
    {
        Debug.Log("Blue Tank Selected!");
        tankSpawner.createTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        Debug.Log("Green Tank Selected!");
        tankSpawner.createTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        Debug.Log("Red Tank Selected!");
        tankSpawner.createTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
