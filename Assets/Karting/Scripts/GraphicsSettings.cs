using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsSettings : MonoBehaviour
{
    public void SetQuality( int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}

