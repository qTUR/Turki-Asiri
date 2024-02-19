using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SDA/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float m_speed;

    public static EnemyData Create(float speed)
    {
        var data = ScriptableObject.CreateInstance<EnemyData>();
        data.m_speed = speed;
        return data;
    }

    public IEnumerator DelayedAction(float delay, System.Action action)
    {
        yield return new WaitForSeconds(delay);
        action.Invoke();
    }
}