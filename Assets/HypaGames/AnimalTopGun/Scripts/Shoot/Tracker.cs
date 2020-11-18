﻿using UnityEngine;
using UnityEngine.Events;

namespace HypaGames.AnimalTopGun
{
    public class Tracker : MonoBehaviour
    {
        public UnityEvent NoEnemiesLeft;

        private int _trackedCount;

        public void AddToTrack()
        {
            _trackedCount++;
        }

        public void RemoveFromTrack()
        {
            _trackedCount--;
            if(_trackedCount == 0)
            {
                NoEnemiesLeft.Invoke();
            }
        }

    }
}
