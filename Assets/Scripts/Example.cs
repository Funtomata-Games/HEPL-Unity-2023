using UnityEngine;

public class Example : MonoBehaviour
{
    public string message = "World!";
    // Start is called before the first frame update
    void Start()
    {
        print("Hello " + message);
    }

    // Update is called once per frame
    void Update()
    {
        print("Around the " + message);
    }
}
