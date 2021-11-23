using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualitySetter : MonoBehaviour
{
    Dropdown _dropdown;

    private void Start()
    {
        _dropdown = GetComponent<Dropdown>();
        _dropdown.options.Clear();
        string[] qualityLevels = QualitySettings.names;

        for (int i = 0; i < qualityLevels.Length; i++)
        {
            Dropdown.OptionData data = new Dropdown.OptionData(qualityLevels[i]);
            _dropdown.options.Add(data);
        }

        _dropdown.value = QualitySettings.GetQualityLevel();

    }

    public void ChangeQuality(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }
}
