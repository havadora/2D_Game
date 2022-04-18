using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float m_fSpringConst = 0f;
    [SerializeField]
    private float m_fOriginalPos = 0f;
    [SerializeField]
    private float m_fPressedPos = 0f;
    [SerializeField]
    private float m_fFlipperSpringDamp = 0f;
    [SerializeField]
    private KeyCode m_flipperInput;
    public GameObject players;
    private HingeJoint m_hingeJoint = null;
    private JointSpring m_jointSpring;
    [SerializeField] private KeySys.KeyType keyType;
    public KeySys.KeyType GetKeyType()
    {
        return keyType;
    }

    private void Start()
    {
        m_hingeJoint = GetComponent<HingeJoint>();
        m_hingeJoint.useSpring = true;

        m_jointSpring = new JointSpring();
        m_jointSpring.spring = m_fSpringConst;
        m_jointSpring.damper = m_fFlipperSpringDamp;

        m_hingeJoint.spring = m_jointSpring;
    }

    public void OnFlipperPressedInternal()
    {
        m_jointSpring.targetPosition = m_fPressedPos;
        m_hingeJoint.spring = m_jointSpring;
    }

    public void OnFlipperReleasedInternal()
    {
        m_jointSpring.targetPosition = m_fOriginalPos;
        m_hingeJoint.spring = m_jointSpring;
    }

    private void Update()
    {
       

        
    }
   
}
