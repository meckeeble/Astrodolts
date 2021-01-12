using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace GameServer
{
    class Player

    {
        public int id;
        public string username;

        public Vector3 position;
        public Quaternion rotation;

        private float speed = 10.0f;
        private float maxVelocityChange = 10.0f;
        private Vector2 input;

        public Player(int _id, string _username, Vector3 _spawnPosition)
        {
            id = _id;
            username = _username;
            position = _spawnPosition;
            rotation = Quaternion.Identity;
        }

        private void Update()
        {
            Move(input);
        }

        private void Move()
        {
            //TODO
            //Resolve vector2 from packet to vector3 for AddForce
            //Implement movement via AddForce as programmed in AddForceMovement.cs
            //Basis for implementation starts:
            //https://www.youtube.com/watch?v=_h6Ta-vxAzQ&t=10m10s
        }

        public void SetInput(Vector2 _input, Quaternion _rotation)
        {
            input = _input;
            rotation = _rotation;
        }
    }
}
