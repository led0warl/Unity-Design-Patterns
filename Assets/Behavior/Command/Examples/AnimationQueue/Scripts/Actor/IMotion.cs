using UnityEngine;

namespace Command.AnimationQueue
{
    public interface IMotion
    {
        Transform transform { get; }
        void Move(Vector3 amount);
        void Scale(Vector3 amount);
        void Rotate(Vector3 amount);
    }
}