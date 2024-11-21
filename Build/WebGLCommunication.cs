using UnityEngine;

public class WebGLCommunication : MonoBehaviour
{
    public GameObject cubeModel;  // Reference to a GameObject (e.g., a cube)

    // This method will be called from JavaScript via postMessage
    public void TriggerUnityFunction()
    {
        Debug.Log("Unity function triggered from JavaScript!");
        // Example: hide the cube when triggered
        if (cubeModel != null)
        {
            cubeModel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Cube Model not assigned!");
        }
    }

    // Method to change the color of the HTML button to yellow
    public void ChangeHtmlButtonColor()
    {
        // Sending a message to the parent window to change the button color
#if UNITY_WEBGL
        Application.ExternalCall("sendMessageToParent", "changeButtonColor");
#endif
    }




}
