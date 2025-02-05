﻿using UnityEngine;
using System.Collections;

public class OutpostUI : MonoBehaviour
{
    public string id;
    public bool isBuilding;
    public int leftBuildTime;
    public int lastUpdateTime = 0;

    public int blood;
    public int unitNum;
    public int outTroopNum;
    public int factionOrder = -1;
    public Vector2Int position;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetUIPosition()
    {
        return LogicToUIPosition(position);
    }

    public static Vector3 LogicToUIPosition(Vector2Int logicVector)
    {
        return new Vector3(logicVector.x + 0.5f, logicVector.y + 0.5f, 0);
    }

    public static Vector2Int UIToLogicPosition(Vector3 v3)
    {
        return new Vector2Int((int)v3.x, (int)v3.y);
    }
}
