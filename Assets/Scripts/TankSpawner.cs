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
        createTank();
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].tankColor);
        TankController tankController = new TankController(tankModel, tankView);
    }
}