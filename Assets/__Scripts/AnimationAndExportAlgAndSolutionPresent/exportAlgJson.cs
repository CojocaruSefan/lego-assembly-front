﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exportAlgJson : MonoBehaviour
{
    public string algorithmType; //aici se salveaza tipul algoritmului

    public void Load(string savedData)
    {
        JsonUtility.FromJsonOverwrite(savedData, this);
    }
}