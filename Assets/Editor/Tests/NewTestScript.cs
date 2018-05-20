using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;



public class NewTestScript
{



    [Test]
    public void NewTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions.

    }



    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        var gameobject = new GameObject();


        gameobject.AddComponent<DirectoryScript>();


        gameobject.GetComponent<DirectoryScript>().DirectoryIndex = 2;

        gameobject.GetComponent<DirectoryScript>().directoryDropdown.value = 2;

        Assert.That(gameobject.GetComponent<DirectoryScript>().DirectoryIndex, Is.EqualTo(gameobject.GetComponent<DirectoryScript>().DropdownGetValue(gameobject.GetComponent<DirectoryScript>().directoryDropdown)));

        yield return null;



    }
    [Test]
    public void Pathfinding_Test()
    {
        var gameobject = new GameObject();

        gameobject.AddComponent<Pathfinding>();
        gameobject.AddComponent<OriginDropdown>();
        gameobject.GetComponent<Pathfinding>().SetRoute();
        gameobject.GetComponent<OriginDropdown>().IndexSeeker = 2;



    }

    [Test]
    
    public void Register_Test()
    {
        var gameobject = new GameObject();

        gameobject.AddComponent<EmailPassword>();
        gameobject.GetComponent<EmailPassword>();

        gameobject.GetComponent<EmailPassword>().Register("iamrivindu@gmail.com", "iamrivindu");




    }
    [Test]

    public void Login_Test()
    {
        var gameobject = new GameObject();

        gameobject.AddComponent<EmailPassword>();
        gameobject.GetComponent<EmailPassword>();

        gameobject.GetComponent<EmailPassword>().Login("iamrivindu@gmail.com","iamrivindu");
    }
}