using UnityEngine;

public class AnotherObject : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(GameSettings.volume);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PersistentObject.staticPublicDebugText = "A";
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(PersistentObject.staticPublicDebugText);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            PersistentObject.GetInstance().SetInstancePrivateText("T");
            PersistentObject.GetInstance().gameObject.name = "Big";
        }
    }
}
