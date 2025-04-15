using UnityEngine.Events;
using UnityEngine;

public class EventPractice : MonoBehaviour
{
    public UnityEvent testEvent = new UnityEvent();

    void Start()
    {
        testEvent.AddListener(TestListener);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            testEvent.Invoke();
        }
    }

    void TestListener()
    {
        print("Test listener called");
    }
}
