﻿using Entitas;
using UnityEngine;

namespace Components
{
    public class DirectionComponent : IComponent
    {
        public Vector3 Direction;
        public float Speed;
    }
}