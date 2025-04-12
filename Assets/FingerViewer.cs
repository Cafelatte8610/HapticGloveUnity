using Unity.VisualScripting;
using UnityEngine;

public class FingerViewer : MonoBehaviour
{
    public SerialReceive serialReceive;

    [SerializeField] private Transform[] Fingers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float readVal = serialReceive.readValue / 1500.0f;
        int fingerAngle = (int)(readVal * -90);
        Debug.Log(readVal);
        foreach (Transform finger in Fingers)
        {
            finger.localRotation = Quaternion.Euler(0, 0, fingerAngle);
        }
    }
}
