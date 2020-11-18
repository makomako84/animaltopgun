﻿using UnityEngine;

namespace HypaGames.PhaseMap
{
    [CreateAssetMenu(fileName = "EnemyWave", menuName = "Hypa Games/Enemy Wave", order = 1)]
    [System.Serializable]
    public class EnemyWaveScriptableObject : ScriptableObject
    {
        public GameObject EnemySpawnerPrefab;
        public int Count;
        public float XOffset;
        public float ZOffset;
        public float Delay;
        public float YAngle;
    }
}