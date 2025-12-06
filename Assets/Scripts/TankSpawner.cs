using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public TankTypes tankType;
        public Material tankColor;
    }

    public List<Tank> tankList;

    public TankView tankView;
    void Start()
    {

    }

    public void createTank(TankTypes tankType)
    {
        if(tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].tankColor);
            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].tankColor);
            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].tankColor);
            TankController tankController = new TankController(tankModel, tankView);
        }
    }
}