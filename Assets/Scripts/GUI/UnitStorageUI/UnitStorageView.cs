﻿using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnitStorageView : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> _countTextList = default;

    public void ActiveUnitStorageView(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public void ViewUnitCount(UnitType type,int value)
    {
        _countTextList[(int)type].text = value.ToString();
    }
}
