using System.Collections;
using System.Collections.Generic;
using Attribute;
using UnityEngine;

public class TestAtribute: MonoBehaviour
{
    private void Start()
    {
        StringEnum temp = StringEnum.Asdf;

        string stringValue = StringValueAttribute.GetStringValue(temp);
    }
}
