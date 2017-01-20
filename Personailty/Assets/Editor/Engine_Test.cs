using NUnit.Framework;
using UnityEngine;
using UnityEditor;

[TestFixture]
public class Engine_Test
{

    [Test]
    public void Crime_Test()
    {
        CreateCrime Crime1 = new CreateCrime();

        Crime1.murder7 = "Valid";

        Crime1.Set_Murder(6);

        var value = Crime1.get_murder();

        Debug.Log(value);

        Assert.AreEqual(value,Crime1.murder7);
    }	// Use this for initialization

}