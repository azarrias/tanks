using UnityEngine;

// make sure that the UI stays in the same rotation that it was at the start
public class UIDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;  

    private Quaternion m_RelativeRotation;     

    private void Start()
    {
        // find the local rotation of the canvas
        m_RelativeRotation = transform.parent.localRotation;
    }

    private void Update()
    {
        // set the current rotation to that local rotation of the canvas
        if (m_UseRelativeRotation)
            transform.rotation = m_RelativeRotation;
    }
}
