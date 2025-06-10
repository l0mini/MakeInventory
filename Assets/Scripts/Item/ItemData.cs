using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemData
{
    public Sprite Icon { get; private set; }

    public ItemData(Sprite icon)
    {
        Icon = icon;
    }
}
