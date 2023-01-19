using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class Stuff
    {
        public int m_bullets;
        public int m_grenades;
        public int m_rockets;

        public Stuff(int bullets, int grenades, int rockets)
        {
            m_bullets = bullets;
            m_grenades = grenades;
            m_rockets = rockets;
        }
        public Stuff(int bullets)
        {
            m_bullets=bullets;
        }
    }

    public Stuff s = new Stuff(5);
    public Stuff s2 = new Stuff(5, 2, 3);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
