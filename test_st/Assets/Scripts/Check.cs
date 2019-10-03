using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour       
{
    public int m_hp, m_mana, m_stamina;
    public int id;

   /* public int hp
    {
      set
        {
            m_hp = value;
        }
        get
        {
            return m_hp;
        }
    }

    public  int mana
    {
        set
        {
            m_mana = value;
        }
        get
        {
            return m_mana;
        }
    }

    public  int stamina
    {
        set
        {
            m_stamina = value;
        }
        get
        {
            return m_stamina;
        }
    }*/

   public void SetHP(int hp)
    {
        hp = m_hp;
    }

   public int GetHP()
    {
        return m_hp;
    }

    public void SetMana(int Mana)
    {
        Mana = m_mana;
    }

    public int GetMana()
    {
        return m_mana;
    }

    public void SetStamina(int Stamina)
    {
        Stamina = m_stamina;
    }

    public int GetStamina()
    {
        return m_stamina;
        ;
    }
}
