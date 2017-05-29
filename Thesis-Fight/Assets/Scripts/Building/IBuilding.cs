﻿using UnityEngine;

public interface IBuilding
{
    bool CanBuild { get; }

    void StartSpawning();
    void ShowPlacementGrid();
    void HidePlacementGrid();
    void UpdateGrid();
}
