using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class CollisionPointPublisher2 : Publisher<Messages.Geometry.PoseStamped>
    {
        public Transform PublishedTransform;
        public string FrameId = "Unity";

        private Messages.Geometry.PoseStamped message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void FixedUpdate()
        {
            UpdateMessage();
        }

        private void InitializeMessage()
        {
            message = new Messages.Geometry.PoseStamped
            {
                header = new Messages.Standard.Header()
                {
                    frame_id = FrameId
                }
            };
        }

        private void UpdateMessage()
        {
            message.header.Update();
            message.pose.position = GetGeometryPoint();
            // message.pose.orientation = GetGeometryQuaternion();

            Publish(message);
        }

        private Messages.Geometry.Point GetGeometryPoint()
        {
            Messages.Geometry.Point geometryPoint = new Messages.Geometry.Point();

            geometryPoint.x = CollisionPoint2.hitPos2.z;
            geometryPoint.y = -CollisionPoint2.hitPos2.x;
            geometryPoint.z = CollisionPoint2.hitPos2.y;
            return geometryPoint;
        }

        //private Messages.Geometry.Quaternion GetGeometryQuaternion()
        //{
        // Messages.Geometry.Quaternion geometryQuaternion = new Messages.Geometry.Quaternion();
        //geometryQuaternion.x = quaternion.x;
        // geometryQuaternion.y = quaternion.y;
        //geometryQuaternion.z = quaternion.z;
        // geometryQuaternion.w = quaternion.w;
        //return geometryQuaternion;
        //}

    }
}