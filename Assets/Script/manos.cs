using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class manos : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController m_Controller = null;
    [SerializeField]
    private Animator m_Animator=null;
    [SerializeField]
    private float m_Speed = 8.0f;
    private const string ANIMATOR_GRIP_PARAM = "Grip";
    private const string ANIMATOR_TRIG_PARAM = "Trigger";

    private float m_GripTarget = 0.0f;
    private float m_CurGrip = 0.0f;
    private float m_TriggerTarget = 0.0f;
    private float m_CurTrigger = 0.0f;
    

    // Update is called once per frame
    void Update()
    {
        m_GripTarget = m_Controller.selectActionValue.action.ReadValue<float>();
        m_TriggerTarget = m_Controller.selectActionValue.action.ReadValue<float>();
        
        if(m_CurGrip != m_GripTarget)
        {
            m_CurGrip = Mathf.MoveTowards(m_CurGrip, m_GripTarget, Time.deltaTime * m_Speed);
            m_Animator.SetFloat(ANIMATOR_GRIP_PARAM, m_CurGrip);
        }
        if (m_CurTrigger != m_TriggerTarget)
        {
            m_CurTrigger = Mathf.MoveTowards(m_CurTrigger, m_TriggerTarget, Time.deltaTime * m_Speed);
            m_Animator.SetFloat(ANIMATOR_TRIG_PARAM, m_CurTrigger);
        }
    }
}
